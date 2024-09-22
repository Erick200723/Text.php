<?php
    $servidor ="localhost";
    $usuario = "root";
    $senha = "";
    $banco = "jardinandino";


    $conexao = new mysqli($servidor, $usuario, $senha, $banco);

    if($conexao -> connect_error){
        die("Flalha na Conexão". $conexao->connect_error);
    }

    $nome = $_POST['nome'];
    $email = $_POST['email'];

    $nome_usuario = $_POST['nome_usuario'];
    $senha = password_hash($_POST['senha'], PASSWORD_DEFAULT);

    $stmt = $conexao->prepare("INSERT INTO usuarios (nome, email, nome_usuario, senha) VALUES (?,?,?,?)");

    $stmt->bind_param("ssss",$nome,$email,$nome_usuario,$senha);

    if($stmt->execute()){
        echo "Dados inseridos com sucesso!";
    } else {
        echo "Erro: " .$stmt->error;
    } 
    $stmt->close();
    $conexao->close();
?>


