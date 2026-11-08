<?php
require 'config.php';
header('Content-Type: application/json');

if (!hash_equals(ADMIN_KEY, $_SERVER['HTTP_X_API_KEY'] ?? '')) {
    http_response_code(401);
    echo json_encode(['error' => 'Unauthorized']);
    exit;
}

if ($_SERVER['REQUEST_METHOD'] === 'GET') {
    $rows = $pdo->query(
        "SELECT id, CONCAT('HF', LPAD(id, 3, '0')) AS reference, hostel, room, category,
                priority, description, status, technician, created_at
         FROM complaints
         ORDER BY (status = 'Resolved') ASC, (priority = 'Emergency') DESC, created_at DESC"
    )->fetchAll(PDO::FETCH_ASSOC);

    foreach ($rows as &$r) { $r['id'] = (int)$r['id']; }
    echo json_encode($rows);
    exit;
}

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $in     = json_decode(file_get_contents('php://input'), true) ?? [];
    $id     = (int)($in['id'] ?? 0);
    $status = $in['status'] ?? '';
    $tech   = trim($in['technician'] ?? '');

    if ($id <= 0 || !in_array($status, ['Pending', 'Assigned', 'Resolved'], true)) {
        http_response_code(400);
        echo json_encode(['error' => 'Invalid input']);
        exit;
    }

    $st = $pdo->prepare('UPDATE complaints SET status = ?, technician = ? WHERE id = ?');
    $st->execute([$status, $tech === '' ? null : $tech, $id]);
    echo json_encode(['ok' => true]);
    exit;
}

http_response_code(405);
