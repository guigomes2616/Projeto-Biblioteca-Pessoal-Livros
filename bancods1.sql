CREATE DATABASE grupo04;
USE grupo04;

-- Criação da tabela de Usuário
CREATE TABLE Usuario (
    id_usuario INT PRIMARY KEY AUTO_INCREMENT,
    nome_usuario VARCHAR(100) NOT NULL,
    email_usuario VARCHAR(100) NOT NULL,
    nick_name VARCHAR(50) NOT NULL,
    senha VARCHAR(50) NOT NULL,
    data_nascimento VARCHAR(10) NOT NULL
);

-- Criação da tabela de Livro
CREATE TABLE Livro (
    id_livro INT PRIMARY KEY AUTO_INCREMENT,
    nome_livro VARCHAR(100) NOT NULL,
    autor_livro VARCHAR(100) NOT NULL,
    ano_publicacao INT(4) NOT NULL,
    id_usuario INT,  -- Referência ao ID do usuário
    FOREIGN KEY (id_usuario) REFERENCES Usuario(id_usuario)
);