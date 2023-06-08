CREATE DATABASE genshin;

USE genshin;

CREATE TABLE characters (
  id INT AUTO_INCREMENT PRIMARY KEY,
  name VARCHAR(100) NOT NULL,
  vision VARCHAR(20) NOT NULL,
  weapon VARCHAR(50) NOT NULL,
  nation VARCHAR(50) NOT NULL
);

INSERT INTO characters (name, vision, weapon, nation)
VALUES
    ('Diluc', 'Pyro', 'Claymore', 'Mondstadt'),
    ('Jean', 'Anemo', 'Sword', 'Mondstadt'),
    ('Keqing', 'Electro', 'Sword', 'Liyue'),
    ('Mona', 'Hydro', 'Catalyst', 'Liyue'),
    ('Klee', 'Pyro', 'Catalyst', 'Mondstadt'),
    ('Qiqi', 'Cryo', 'Sword', 'Liyue'),
    ('Venti', 'Anemo', 'Bow', 'Mondstadt'),
    ('Xiao', 'Anemo', 'Polearm', 'Liyue'),
    ('Ganyu', 'Cryo', 'Bow', 'Liyue'),
    ('Childe', 'Hydro', 'Bow', 'Snezhnaya'),
    ('Zhongli', 'Geo', 'Polearm', 'Liyue'),
    ('Eula', 'Cryo', 'Claymore', 'Mondstadt'),
    ('Albedo', 'Geo', 'Sword', 'Mondstadt'),
    ('Xingqiu', 'Hydro', 'Sword', 'Liyue'),
    ('Fischl', 'Electro', 'Bow', 'Mondstadt'),
    ('Bennett', 'Pyro', 'Sword', 'Mondstadt'),
    ('Sucrose', 'Anemo', 'Catalyst', 'Mondstadt'),
    ('Rosaria', 'Cryo', 'Polearm', 'Mondstadt'),
    ('Noelle', 'Geo', 'Claymore', 'Mondstadt'),
    ('Hu Tao', 'Pyro', 'Polearm', 'Liyue'),
    ('Xiangling', 'Pyro', 'Polearm', 'Liyue'),
    ('Beidou', 'Electro', 'Claymore', 'Liyue'),
    ('Raiden Shogun', 'Electro', 'Polearm', 'Inazuma'),
    ('Kujou Sara', 'Electro', 'Bow', 'Inazuma'),
    ('Yoimiya', 'Pyro', 'Bow', 'Inazuma'),
    ('Sayu', 'Anemo', 'Claymore', 'Inazuma'),
    ('Kamisato Ayaka', 'Cryo', 'Sword', 'Inazuma'),
    ('Kokomi', 'Hydro', 'Catalyst', 'Fontaine'),
    ('Sangonomiya Kokomi', 'Hydro', 'Catalyst', 'Fontaine'),
    ('Raiden Ei', 'Electro', 'Polearm', 'Inazuma');
