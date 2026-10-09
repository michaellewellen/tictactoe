CREATE TABLE IF NOT EXISTS tictactoe (
    id SERIAL PRIMARY KEY,
    game_id int NOT NULL,
    position int NOT NULL,
    piece char(1) NOT NULL
);