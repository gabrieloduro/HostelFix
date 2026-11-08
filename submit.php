<?php
require 'config.php';
header('Content-Type: application/json');

if ($_SERVER['REQUEST_METHOD'] !== 'POST') {
    http_response_code(405);
    echo json_encode(['error' => 'Invalid request']);
    exit;
}

// Edit these lists. index.html must contain the same values.
$hostels = ['Hostel A', 'Hostel B', 'Hostel C'];
$cats    = ['Plumbing', 'Electrical', 'Furniture', 'Internet', 'Other'];
$prios   = ['Medium', 'High', 'Emergency'];

// Honeypot: real students never fill this hidden field
if (!empty($_POST['website'])) {
    echo json_encode(['reference' => 'HF000']);
    exit;
}

$hostel = $_POST['hostel'] ?? '';
$room   = trim($_POST['room'] ?? '');
$cat    = $_POST['category'] ?? '';
$prio   = $_POST['priority'] ?? '';
$desc   = mb_substr(trim($_POST['description'] ?? ''), 0, 500);

if (!in_array($hostel, $hostels, true) || !in_array($cat, $cats, true) ||
    !in_array($prio, $prios, true) || $room === '' || mb_strlen($room) > 20) {
    http_response_code(400);
    echo json_encode(['error' => 'Fill in every field and try again.']);
    exit;
}

// Rate limit per IP. Hostel Wi-Fi often shares one IP, so keep this generous.
$ip = $_SERVER['REMOTE_ADDR'] ?? '';
$st = $pdo->prepare('SELECT COUNT(*) FROM complaints WHERE ip = ? AND created_at > (NOW() - INTERVAL 10 MINUTE)');
$st->execute([$ip]);
if ($st->fetchColumn() >= 20) {
    http_response_code(429);
    echo json_encode(['error' => 'Too many complaints from this network. Try again in a few minutes.']);
    exit;
}

$st = $pdo->prepare('INSERT INTO complaints (hostel, room, category, priority, description, ip) VALUES (?,?,?,?,?,?)');
$st->execute([$hostel, $room, $cat, $prio, $desc === '' ? null : $desc, $ip]);

echo json_encode(['reference' => 'HF' . str_pad($pdo->lastInsertId(), 3, '0', STR_PAD_LEFT)]);
