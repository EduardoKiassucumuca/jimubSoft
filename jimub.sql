-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Tempo de geração: 09-Nov-2021 às 22:29
-- Versão do servidor: 10.4.20-MariaDB
-- versão do PHP: 7.4.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `jimub`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_actividade`
--

CREATE TABLE `tb_actividade` (
  `id_actividade` int(100) NOT NULL,
  `id_comissaoR` int(100) NOT NULL,
  `tema` varchar(200) CHARACTER SET utf8 NOT NULL,
  `objectivo` varchar(200) CHARACTER SET utf8 NOT NULL,
  `orador` varchar(100) CHARACTER SET utf8 NOT NULL,
  `estado` varchar(100) NOT NULL,
  `local` varchar(50) NOT NULL,
  `data_actividade` date NOT NULL,
  `hora_actividade` varchar(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_actividade`
--

INSERT INTO `tb_actividade` (`id_actividade`, `id_comissaoR`, `tema`, `objectivo`, `orador`, `estado`, `local`, `data_actividade`, `hora_actividade`) VALUES
(5, 10, 'Estudo bíblico S.Mateus 5', 'Instruir sobre as bem-aventuranças.', 'Celso Bessa', 'Realizada', 'Jacó', '2020-02-19', '18:30'),
(35, 13, 'k', 'jlnln', 'kklk', 'Não-Realizada', 'Local da actividadekjkjjkj', '2020-06-09', '00:10'),
(39, 0, 'kkhh', 'Objectivo...jkkh', 'Oradorbmj', 'Realizada', 'Local da actividadehjgjhg', '2020-02-21', '18:00'),
(40, 0, 'Temannm', 'Objectivo...nm', 'Oradormnm', 'mn', 'Local da actividaden', '2020-01-30', '03:00'),
(41, 0, 'Temannm', 'Objectivo...nm', 'Oradormnm', 'mn', 'Local da actividaden', '2020-01-30', '03:00');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_cargo`
--

CREATE TABLE `tb_cargo` (
  `id_cargo` int(100) NOT NULL,
  `cargo` varchar(150) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_cargo`
--

INSERT INTO `tb_cargo` (`id_cargo`, `cargo`) VALUES
(9, 'Sec.Executivo'),
(10, 'Sec.Evangelismo'),
(18, 'Base'),
(19, 'Director'),
(20, 'Vice-Director'),
(21, 'Tesoureiro'),
(22, 'Vic.Sec.Evangelismo'),
(23, 'Sec.Comunicação.e.Informação'),
(24, 'Vic.Sec.Comunicação.e.Informação'),
(25, 'Sec.Fraternidade.e.Ecumenismo'),
(26, 'Vic.Sec.Fraternidade.e.Ecumenismo'),
(27, 'Sec.Recreio.e.Desporto'),
(28, 'Vic.Sec.Recreio.e.Desporto '),
(29, 'Sec.Serviços.Sociais.e.Comunitarios'),
(30, 'Vic.Sec.Serviços.Sociais.e.Comunitarios'),
(31, 'Coordenador.Dos.Adolescentes'),
(32, 'Vic.Coordenador.Dos.Adolescentes'),
(33, 'Sec.Cultura'),
(34, 'Vic.Sec.Cultura');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_categoria`
--

CREATE TABLE `tb_categoria` (
  `id_categoria` int(100) NOT NULL,
  `descricao` varchar(250) CHARACTER SET utf8 NOT NULL,
  `data_atual` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_comissao`
--

CREATE TABLE `tb_comissao` (
  `id_comissao` int(100) NOT NULL,
  `comissao` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_comissao`
--

INSERT INTO `tb_comissao` (`id_comissao`, `comissao`) VALUES
(8, 'Nenhuma'),
(9, 'C.Informação'),
(10, 'Evangelismo'),
(12, 'Fraternidade'),
(13, 'Rec.Desporto'),
(14, 'SSC'),
(15, 'Cultura');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_cota`
--

CREATE TABLE `tb_cota` (
  `id_cota` int(100) NOT NULL,
  `id_membro` int(100) NOT NULL,
  `id_mes` int(100) NOT NULL,
  `total_apagar` double NOT NULL,
  `total_pago` double NOT NULL,
  `troco` double NOT NULL,
  `total` int(100) NOT NULL,
  `data_pagamento` datetime(6) NOT NULL,
  `estadop` varchar(100) NOT NULL,
  `data_atualC` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_cota`
--

INSERT INTO `tb_cota` (`id_cota`, `id_membro`, `id_mes`, `total_apagar`, `total_pago`, `troco`, `total`, `data_pagamento`, `estadop`, `data_atualC`) VALUES
(1, 8, 1, 0, 0, 0, 0, '0000-00-00 00:00:00.000000', '', '2019-01-06 18:53:42'),
(2, 8, 2, 0, 0, 0, 0, '0000-00-00 00:00:00.000000', '', '2019-01-08 00:42:23'),
(52, 9, 78, 100, 150, 50, 100, '2019-01-12 00:00:00.000000', 'Pago', '2019-01-12 22:00:41');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_emprestimo`
--

CREATE TABLE `tb_emprestimo` (
  `id_emprestimo` int(100) NOT NULL,
  `id_membro` int(100) NOT NULL,
  `id_livro` int(100) NOT NULL,
  `quantidade` int(20) NOT NULL,
  `total_pago` double NOT NULL,
  `total_apagar` double NOT NULL,
  `troco` double NOT NULL,
  `estado` varchar(45) NOT NULL,
  `data_emprestimo` datetime NOT NULL,
  `data_entrega` date NOT NULL,
  `data_atual` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_entrada`
--

CREATE TABLE `tb_entrada` (
  `id_entrada` int(100) NOT NULL,
  `id_membro` int(100) NOT NULL,
  `id_total` int(100) NOT NULL,
  `descricao` varchar(100) CHARACTER SET utf8 NOT NULL,
  `valor` double NOT NULL,
  `data_entrada` datetime(6) NOT NULL,
  `data_atual` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_filiacao`
--

CREATE TABLE `tb_filiacao` (
  `id_filiacao` int(10) NOT NULL,
  `pai` varchar(50) NOT NULL,
  `mae` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_filiacao`
--

INSERT INTO `tb_filiacao` (`id_filiacao`, `pai`, `mae`) VALUES
(15, 'Samora Massangano Manuel Gomes', 'Joyce Stela de Oliveira Gomes'),
(16, 'António da Conceição Ferreira', 'Esmeralda Ernesto Francisco'),
(17, 'Manuel António V da Silva', 'Carla P. D. da Silva'),
(19, 'João Gregório D Silva Ferreira', 'Maria Domingas Francisco'),
(30, 'Perdo Augusto Lopes', 'Leonora Munana Vicente Lopes'),
(31, 'pedro Jose Domingos', 'Maria Morais Ribeiro'),
(32, 'Dias António', 'Vanda Dos Santos '),
(33, 'Jose Alberto Joaquim', 'Maria Augusta Lopes Pedro'),
(34, 'Cristavão Gaspar Fernando', 'Engrácia Domingos Miguel'),
(35, 'Ambroso Francisco Cpembe', 'Fatima Dala Morais'),
(36, 'Miguel Dias Lourenco', 'Margarida Manuela Lourenco'),
(37, 'Alsides Manuel Cristovão Neto', 'Delfina Dos Anjos Fortunado Si'),
(38, 'Marco Paulo Delfino Jeremias', 'Fernanda L.C.L Jeremias'),
(39, 'Joaquim Cardoso Tando', 'Antonica Inácio Lenge'),
(40, 'Jose Daniel Dos Reis', 'Maria Isabel Campos Da Conscen'),
(41, 'Alcides Manuel Cristovao Neto', 'Delfina Dos Anjos F.S. Neto'),
(42, 'Célio Breve', 'Rita Bernado'),
(43, 'Mateus Quissua', 'Lilia Diogo'),
(44, 'Selcio Edgar Da Silva Bessa', 'Isabel Macia Vicente Boa Ventu'),
(45, 'Wilson Miguel Bernardo de Andrade', 'Marlene Jacinto Pimentel'),
(46, 'Célio Manuel Domingos', 'Angelina Manuel G. Domingos'),
(47, 'António De Carvaalho Borges', 'Maria Ricardo Da Costa Bosges'),
(48, 'Pedro do Nascimento', 'Cecilia Caetano'),
(49, 'Celcio Edgar Da Silva Bessa', 'Isabel Marcia V. B. Bessa'),
(50, 'Justino Francisco Fernandes', 'Isabel da Conceicao Miguel '),
(51, 'Michel Agostinho', 'Helena Luis'),
(52, 'Pedro Gomes Miguel', 'Teresa Adão Van-Dúnem Miguel'),
(53, 'Baltazar Aspirante Manuel', 'Isabel Nazare da C. Diogo'),
(54, 'Joaquim Felipe Gomes', 'teresa José'),
(55, 'Francisco de Sousa', 'Luzia Joaquim André Casimiro'),
(56, 'Baltazar Aspirante Manuel', 'Isabel Nazare da C. Diogo'),
(57, 'Lauriano Castelo Campos Francisco', 'Wassuka Da Conscensão R.De Oli'),
(58, 'Evaristo Amoroso Lucas Chissola', 'Mariana Reis Quiambata'),
(59, 'António Orlando Ramos da Cruz', 'Madalena Baptista R. R da Cruz'),
(60, 'António Orlando Ramos da Cruz', 'Madalena Baptista R. R da Cruz'),
(61, 'António Orlando Ramos da Cruz', 'Madalena Baptista R. R da Cruz'),
(62, 'António Orlando Ramos da Cruz', 'Madalena Baptista R. R da Cruz'),
(63, 'António Orlando Ramos da Cruz', 'Madalena Baptista R. R da Cruz'),
(64, 'António Orlando Ramos da Cruz', 'Madalena Baptista R. R da Cruz'),
(65, 'EVRISTO AMOROSO LUCAS CHISSOLA', 'MARIANA REIS KIAMBATA'),
(66, 'EVRISTO AMOROSO LUCAS CHISSOLA', 'MARIANA REIS KIAMBATA'),
(67, 'EVRISTO AMOROSO LUCAS CHISSOLA', 'MARIANA REIS KIAMBATA'),
(68, 'EVRISTO AMOROSO LUCAS CHISSOLA', 'MARIANA REIS KIAMBATA'),
(69, 'ENOQUE SETULA SIMÕES', 'ZINHA FRANCISCO FERREIRA'),
(70, 'JOSE CARLOS CRISTOVÃO MATEUS', 'TERESA MARIA MANUEL ANTONIO'),
(71, 'António Cassinda Caterça', 'Domingas Manuel Martins'),
(72, 'Julio Fernando Manuel Goncalves', 'Julia Ferreira da S.Goncalves'),
(73, 'Rui Jorge de Lima Carmelino', 'Elisângela Avelino V. Miranda'),
(74, 'ISAAC ANTONIO RODRIGUES DA COSTA', 'ANTONIA DOMINGOS ADRIANO '),
(75, 'Enoque Setula Simões', 'Zinha Francisco Ferreira'),
(76, 'Manuel Luís Garcia Cazequeza', 'Vitória Da Silva F. Cazequeza'),
(77, 'Paulino Gaspar Candido', 'Isabel Mateus G.Sales Candido'),
(78, 'ANTONIO MOISES', 'CRSITINIA VALERIANA'),
(79, 'Nicolau José Agostinho', 'Bernarda José Manuel Agostinho'),
(80, 'Isaac António Rodrigues Da Costa', 'Antônia D. Adriano Da Costa'),
(81, 'JOÃO ADÃO', 'APOLINARIA NEGRA ALVISA'),
(82, 'Ismael de Jesus Nicolau ', 'Suzana Ginga Gonçalves'),
(83, 'António Domingos Paulo', 'Eva Ernesto Quimbaca'),
(84, 'Lauriano Castelo Campos ', 'Wuanssuca Da C. R. De Oliveira'),
(85, 'JÚLIO FERNANDO MANUEL GONÇALVES', 'JÚLIA FERREIRA DA SILVA GONÇAL'),
(86, 'António Orlando Ramos da Cruz', 'Madalena Baptista R.R da Cruz'),
(87, 'Victor Manuel de Moura Inglês Garcia', 'Nazareth Duarte D. F. Garcia'),
(88, 'José Alexandre Neto', 'Juliana António Manuel'),
(89, 'PEDRO FRANCISCO BARROS ', 'MARIA ARTUR DOMINGOS BARROS'),
(90, 'Yuri César Manuel', 'Rita Sebastião Francisco'),
(91, 'Armando José', 'Teresa Isabel Marçal José'),
(92, 'PEDRO FRANCISCO BARROS', 'MARIA ARTUR BARROS'),
(93, 'Francisco Almeida Dias Dos Santos', 'Maria Da Glória Figueira'),
(94, 'Edmundo Silvestre de Almeida', 'Edna Cândida S. F de Almeida '),
(95, 'Paiteste', 'Mãeteste'),
(96, 'Alfredo António Quindai', 'Conceição Esmeraldina Ambriz'),
(97, 'Domingos Alberto Da Fonseca Francisco', 'Ilda Gomes Manuel'),
(98, 'Ngagula Da Conceição CHaves ', 'Carmizé De A. S Carvalho'),
(99, 'Sebastião Andre Domingos', 'Edna Teresa Fernandes Afonso'),
(100, 'Pedro Maria ', 'Medine Ferreira'),
(101, 'Ezequiel Bernardo Silvestre', 'Silvia Vanuza Lopes Francisco'),
(102, 'Alexandre Gaspar Fernando', 'Madalena José Jorge Fernando'),
(103, 'Ernestro Lidador ', 'Juliana Buta'),
(104, 'Armando Zua', 'Isabel Gaspar Cristovão'),
(105, 'Adriano Pedro Fernandes', 'Suzana Diogo José'),
(106, 'José Carlos Francisco Catumbila', 'Ana Manuela Da Silva'),
(107, 'Mateus Francisco', 'Maria FRancisco '),
(108, 'Não sabe', 'Luzia António'),
(109, 'Domingos Ginbo', 'Elena Candeia '),
(110, 'Manuel Simão', 'Claudia Simão'),
(111, 'Alberto Katanga', 'Olga Katanga'),
(112, 'Miguel Pedro Vicente', 'Valeria Gomes Manuel Vicente'),
(113, 'José Paulo kiano Augusto', 'Madalena Bernardo Gerônimo'),
(114, 'Mario Antonio Marque', 'Maria Elisa da Costa Barbosa'),
(115, 'Alipio Ferreira Neto', 'Guinha Adriano'),
(116, 'Alipio Neto', 'Guinha Adriano'),
(117, 'Manuel Dias', 'Lídia Maximica'),
(118, 'Ivanilson dos Santos', 'Marlene dos Santos'),
(119, 'Cândido José Quinjango', 'Briatriz  Ferreira '),
(120, 'Adão Anselmo', 'Faustina José Júnior'),
(121, 'António Carlos Francisco Caetano', 'Jandira Valeria Divua Menezes'),
(122, 'Sabastião Elvino Mateus', 'Engrácia Balduíno Francisco'),
(123, 'Aurélio De Fátima Felisberto', 'Marisa Severino D.S Felisberto'),
(124, 'Mario Nhanga', 'Evalina Cassua'),
(125, 'Gentil Gourjel', 'Inácia Clemente'),
(126, 'Teodoro Webba', 'Hedwiges Webba'),
(127, 'Mateus Cassule', 'Sara Silva'),
(128, 'Festa Guialo', 'Maria José'),
(129, 'Júlio Lisboa', 'Edna Botélio'),
(130, 'Carlos Da Silva', 'Victória Alfredo'),
(131, 'Telmo Quindai', 'Yara Clemente'),
(132, 'Joaquim Adão', 'Esperança Miguel'),
(133, 'Nuno Kunateke', 'Joana Kunatete'),
(134, 'Joaquim Francisco', 'Teresa de Rosário'),
(135, 'Ábílio Da Cruz', 'Julieta Da Silva'),
(136, 'Osvaldo Garcia', 'Laurinda José'),
(137, 'Orlando Pinto', 'Marlene C. Ngunza Pinto'),
(138, 'João Marçal', 'Ana João'),
(139, 'Manuel Andrade Jorge', 'Cláudia Iracema A. O. Jorge'),
(140, 'André Cauma', 'Suzana Gonçalves'),
(141, 'Mateus Cassua', 'Marcela Cassua'),
(142, 'António Salimane B. Camutari', 'Francisca João L. Camutari');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_fornecedor`
--

CREATE TABLE `tb_fornecedor` (
  `id_fornecedor` int(100) NOT NULL,
  `nome` varchar(150) CHARACTER SET utf8 NOT NULL,
  `telefone1` int(30) NOT NULL,
  `telefone2` int(30) NOT NULL,
  `data_atual` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_grupo`
--

CREATE TABLE `tb_grupo` (
  `id_grupo` int(100) NOT NULL,
  `grupo` varchar(100) NOT NULL,
  `dirigente1` varchar(100) NOT NULL,
  `dirigente2` varchar(100) NOT NULL,
  `coordenador` varchar(100) NOT NULL,
  `vice-coordenador` varchar(100) NOT NULL,
  `estado` varchar(50) NOT NULL,
  `data_atual` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_livros`
--

CREATE TABLE `tb_livros` (
  `id_livro` int(100) NOT NULL,
  `id_forncedor` int(100) NOT NULL,
  `id_categoria` int(100) NOT NULL,
  `titulo` varchar(150) CHARACTER SET utf8 NOT NULL,
  `descricao` varchar(250) CHARACTER SET utf8 NOT NULL,
  `autor` varchar(100) CHARACTER SET utf8 NOT NULL,
  `imagem` varchar(200) NOT NULL,
  `quantidade` int(20) NOT NULL,
  `valor_emprestimo` double NOT NULL,
  `data_atual` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_log`
--

CREATE TABLE `tb_log` (
  `id_log` int(6) NOT NULL,
  `id_user` int(6) NOT NULL,
  `descricao` varchar(1000) NOT NULL,
  `data` date NOT NULL,
  `hora` time NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_log`
--

INSERT INTO `tb_log` (`id_log`, `id_user`, `descricao`, `data`, `hora`) VALUES
(1, 1, 'O Utilizador JIMUB logou no sistema em 2021-10-20 ás 23:29:15', '2021-10-20', '23:29:15'),
(2, 1, 'O Utilizador JIMUB inseriu o utilizador Eli com o código \"8\" no sistema em 2021-10-20 ás 23:29:39', '2021-10-20', '23:29:39'),
(3, 1, 'O Utilizador \"JIMUB\" alterou o nome do utilizador \"Eli\"para \"Elia\" com o código: \"1\" e o cargo \"Diretor(a)\"para \"Diretor(a)\"\" no sistema em 2021-10-20 ás 23:30:25', '2021-10-20', '23:30:25'),
(4, 1, 'O Utilizador \"JIMUB\" eliminou o utilizador \"Elia\" com o código: \"5\" no sistema em 2021-10-20 ás 23:30:46', '2021-10-20', '23:30:46'),
(5, 1, 'O Utilizador JIMUB logou no sistema em 2021-10-20 ás 23:54:56', '2021-10-20', '23:54:56'),
(6, 1, 'O Utilizador JIMUB logou no sistema em 2021-10-21 ás 0:1:50', '2021-10-21', '00:01:50'),
(7, 1, 'O Utilizador JIMUB logou no sistema em 2021-10-21 ás 20:17:39', '2021-10-21', '20:17:39'),
(8, 1, 'O Utilizador JIMUB logou no sistema em 2021-10-21 ás 20:43:48', '2021-10-21', '20:43:48'),
(9, 1, 'O Utilizador JIMUB logou no sistema em 2021-10-21 ás 20:48:26', '2021-10-21', '20:48:26'),
(10, 1, 'O Utilizador JIMUB logou no sistema em 2021-10-21 ás 21:29:16', '2021-10-21', '21:29:16'),
(11, 1, 'O Utilizador jimub logou no sistema em 2021-10-21 ás 21:36:13', '2021-10-21', '21:36:13'),
(12, 1, 'O Utilizador jimub logou no sistema em 2021-10-21 ás 21:44:2', '2021-10-21', '21:44:02'),
(13, 1, 'O Utilizador jimub logou no sistema em 2021-10-22 ás 16:37:48', '2021-10-22', '16:37:48'),
(14, 1, 'O Utilizador jimub logou no sistema em 2021-10-22 ás 23:53:52', '2021-10-22', '23:53:52'),
(15, 1, 'O Utilizador jimub logou no sistema em 2021-10-23 ás 0:25:21', '2021-10-23', '00:25:21'),
(16, 1, 'O Utilizador jimub logou no sistema em 2021-10-23 ás 0:27:47', '2021-10-23', '00:27:47'),
(17, 1, 'O Utilizador jimub logou no sistema em 2021-10-23 ás 1:23:55', '2021-10-23', '01:23:55'),
(18, 1, 'O Utilizador jimub logou no sistema em 2021-10-23 ás 1:32:34', '2021-10-23', '01:32:34'),
(19, 1, 'O Utilizador jimub logou no sistema em 2021-10-23 ás 1:45:52', '2021-10-23', '01:45:52'),
(20, 1, 'O Utilizador jimub logou no sistema em 2021-10-23 ás 1:54:57', '2021-10-23', '01:54:57'),
(21, 1, 'O Utilizador jimub logou no sistema em 2021-10-23 ás 1:56:7', '2021-10-23', '01:56:07'),
(22, 1, 'O Utilizador jimub logou no sistema em 2021-10-23 ás 15:6:9', '2021-10-23', '15:06:09'),
(23, 1, 'O Utilizador jimub logou no sistema em 2021-10-23 ás 15:9:53', '2021-10-23', '15:09:53'),
(24, 1, 'O Utilizador jimub logou no sistema em 2021-10-23 ás 15:16:24', '2021-10-23', '15:16:24'),
(25, 1, 'O Utilizador jimub logou no sistema em 2021-10-23 ás 15:19:37', '2021-10-23', '15:19:37'),
(26, 1, 'O Utilizador jimub logou no sistema em 2021-10-23 ás 15:26:1', '2021-10-23', '15:26:01'),
(27, 1, 'O Utilizador jimub logou no sistema em 2021-10-23 ás 15:26:29', '2021-10-23', '15:26:29'),
(28, 1, 'O Utilizador jimub logou no sistema em 2021-10-23 ás 15:27:40', '2021-10-23', '15:27:40'),
(29, 1, 'O Utilizador jimub logou no sistema em 2021-10-23 ás 15:31:46', '2021-10-23', '15:31:46'),
(30, 1, 'O Utilizador jimub logou no sistema em 2021-10-23 ás 15:50:34', '2021-10-23', '15:50:34'),
(31, 1, 'O Utilizador jimub logou no sistema em 2021-10-23 ás 16:14:31', '2021-10-23', '16:14:31'),
(32, 1, 'O Utilizador jimub logou no sistema em 2021-10-23 ás 16:19:20', '2021-10-23', '16:19:20'),
(33, 1, 'O Utilizador jimub logou no sistema em 2021-10-23 ás 23:39:32', '2021-10-23', '23:39:32'),
(34, 1, 'O Utilizador jimub logou no sistema em 2021-10-23 ás 23:45:30', '2021-10-23', '23:45:30'),
(35, 1, 'O Utilizador jimub logou no sistema em 2021-10-24 ás 0:22:24', '2021-10-24', '00:22:24'),
(36, 1, 'O Utilizador jimub logou no sistema em 2021-10-24 ás 0:30:53', '2021-10-24', '00:30:53'),
(37, 1, 'O Utilizador jimub logou no sistema em 2021-10-24 ás 0:38:12', '2021-10-24', '00:38:12'),
(38, 1, 'O Utilizador jimub logou no sistema em 2021-10-24 ás 0:44:22', '2021-10-24', '00:44:22'),
(39, 1, 'O Utilizador jimub logou no sistema em 2021-10-24 ás 1:9:10', '2021-10-24', '01:09:10'),
(40, 1, 'O Utilizador jimub logou no sistema em 2021-10-24 ás 1:12:26', '2021-10-24', '01:12:26'),
(41, 1, 'O Utilizador jimub logou no sistema em 2021-10-24 ás 1:22:11', '2021-10-24', '01:22:11'),
(42, 1, 'O Utilizador jimub logou no sistema em 2021-10-24 ás 1:37:11', '2021-10-24', '01:37:11'),
(43, 1, 'O Utilizador jimub logou no sistema em 2021-10-24 ás 11:33:37', '2021-10-24', '11:33:37'),
(44, 1, 'O Utilizador jimub logou no sistema em 2021-10-24 ás 10:44:7', '2021-10-24', '10:44:07'),
(45, 1, 'O Utilizador jimub logou no sistema em 2021-10-24 ás 11:50:4', '2021-10-24', '11:50:04'),
(46, 1, 'O Utilizador jimub logou no sistema em 2021-10-24 ás 11:52:56', '2021-10-24', '11:52:56'),
(47, 1, 'O Utilizador jimub logou no sistema em 2021-10-24 ás 11:58:38', '2021-10-24', '11:58:38'),
(48, 1, 'O Utilizador jimub logou no sistema em 2021-10-24 ás 13:4:26', '2021-10-24', '13:04:26'),
(49, 1, 'O Utilizador jimub logou no sistema em 2021-10-24 ás 12:23:54', '2021-10-24', '12:23:54'),
(50, 1, 'O Utilizador jimub logou no sistema em 2021-10-24 ás 11:37:32', '2021-10-24', '11:37:32'),
(51, 1, 'O Utilizador jimub logou no sistema em 2021-10-24 ás 11:48:6', '2021-10-24', '11:48:06'),
(52, 1, 'O Utilizador jimub logou no sistema em 2021-10-24 ás 14:14:34', '2021-10-24', '14:14:34'),
(53, 1, 'O Utilizador jimub logou no sistema em 2021-10-24 ás 13:40:15', '2021-10-24', '13:40:15'),
(54, 1, 'O Utilizador jimub logou no sistema em 2021-10-24 ás 13:54:51', '2021-10-24', '13:54:51'),
(55, 1, 'O Utilizador jimub logou no sistema em 2021-10-24 ás 13:55:29', '2021-10-24', '13:55:29'),
(56, 1, 'O Utilizador jimub logou no sistema em 2021-10-24 ás 13:1:33', '2021-10-24', '13:01:33'),
(57, 1, 'O Utilizador jimub logou no sistema em 2021-10-24 ás 13:56:48', '2021-10-24', '13:56:48'),
(58, 1, 'O Utilizador jimub logou no sistema em 2021-10-24 ás 13:58:30', '2021-10-24', '13:58:30'),
(59, 1, 'O Utilizador jimub logou no sistema em 2021-10-24 ás 14:52:53', '2021-10-24', '14:52:53'),
(60, 1, 'O Utilizador jimub logou no sistema em 2021-10-25 ás 17:57:59', '2021-10-25', '17:57:59'),
(61, 1, 'O Utilizador jimub logou no sistema em 2021-10-25 ás 18:2:6', '2021-10-25', '18:02:06'),
(62, 1, 'O Utilizador jimub logou no sistema em 2021-10-25 ás 22:11:58', '2021-10-25', '22:11:58'),
(63, 1, 'O Utilizador jimub logou no sistema em 2021-10-25 ás 22:13:30', '2021-10-25', '22:13:30'),
(64, 1, 'O Utilizador jimub logou no sistema em 2021-10-25 ás 22:20:20', '2021-10-25', '22:20:20'),
(65, 1, 'O Utilizador jimub logou no sistema em 2021-10-25 ás 22:21:42', '2021-10-25', '22:21:42'),
(66, 1, 'O Utilizador jimub logou no sistema em 2021-10-25 ás 22:23:42', '2021-10-25', '22:23:42'),
(67, 1, 'O Utilizador jimub logou no sistema em 2021-10-30 ás 13:8:36', '2021-10-30', '13:08:36'),
(68, 1, 'O Utilizador jimub logou no sistema em 2021-10-30 ás 13:27:3', '2021-10-30', '13:27:03'),
(69, 1, 'O Utilizador jimub logou no sistema em 2021-10-30 ás 13:50:54', '2021-10-30', '13:50:54'),
(70, 1, 'O Utilizador jimub logou no sistema em 2021-10-30 ás 13:59:48', '2021-10-30', '13:59:48'),
(71, 1, 'O Utilizador jimub logou no sistema em 2021-10-30 ás 14:22:26', '2021-10-30', '14:22:26'),
(72, 1, 'O Utilizador jimub logou no sistema em 2021-10-30 ás 14:56:0', '2021-10-30', '14:56:00'),
(73, 1, 'O Utilizador jimub logou no sistema em 2021-10-31 ás 12:8:52', '2021-10-31', '12:08:52'),
(74, 1, 'O Utilizador jimub logou no sistema em 2021-10-31 ás 12:37:49', '2021-10-31', '12:37:49'),
(75, 1, 'O Utilizador jimub logou no sistema em 2021-10-31 ás 12:48:50', '2021-10-31', '12:48:50'),
(76, 1, 'O Utilizador jimub logou no sistema em 2021-10-31 ás 13:0:46', '2021-10-31', '13:00:46'),
(77, 1, 'O Utilizador jimub logou no sistema em 2021-11-7 ás 11:34:28', '2021-11-07', '11:34:28'),
(78, 1, 'O Utilizador jimub logou no sistema em 2021-11-7 ás 11:43:40', '2021-11-07', '11:43:40'),
(79, 1, 'O Utilizador jimub logou no sistema em 2021-11-7 ás 12:14:17', '2021-11-07', '12:14:17'),
(80, 1, 'O Utilizador jimub logou no sistema em 2021-11-7 ás 12:55:17', '2021-11-07', '12:55:17'),
(81, 1, 'O Utilizador jimub logou no sistema em 2021-11-7 ás 12:56:22', '2021-11-07', '12:56:22'),
(82, 1, 'O Utilizador jimub logou no sistema em 2021-11-9 ás 20:34:35', '2021-11-09', '20:34:35');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_membros`
--

CREATE TABLE `tb_membros` (
  `id_membro` int(100) NOT NULL,
  `nome` varchar(100) CHARACTER SET utf8 NOT NULL,
  `alcunha` varchar(100) CHARACTER SET utf8 NOT NULL,
  `telefone1` int(50) NOT NULL,
  `telefone2` int(50) NOT NULL,
  `idade` int(50) NOT NULL,
  `sexo` varchar(50) NOT NULL,
  `id_morada` int(50) NOT NULL,
  `estado_civil` varchar(50) NOT NULL,
  `BI_Cedula` varchar(100) NOT NULL,
  `id_filiacao` int(40) NOT NULL,
  `email` varchar(100) NOT NULL,
  `facebook` varchar(100) NOT NULL,
  `areaFormacao` varchar(50) NOT NULL,
  `nivelEscolar` varchar(20) NOT NULL,
  `escola` varchar(100) NOT NULL,
  `ramo` varchar(1000) NOT NULL,
  `profissao` varchar(80) NOT NULL,
  `id_cargo` int(100) NOT NULL,
  `id_comissao` int(100) NOT NULL,
  `grupo` varchar(100) NOT NULL,
  `data_nascimento` date NOT NULL,
  `cat_membro` varchar(100) NOT NULL,
  `classe` varchar(150) NOT NULL,
  `imagem` varchar(200) NOT NULL,
  `data_emissao` date NOT NULL,
  `como_ingressou` varchar(100) NOT NULL,
  `presenca` varchar(100) NOT NULL,
  `motivo` varchar(100) NOT NULL,
  `igreja_Anterior` varchar(100) NOT NULL,
  `funcaoA_Exercer` varchar(100) NOT NULL,
  `descricao_Organizacao` varchar(100) NOT NULL,
  `estado` varchar(100) NOT NULL,
  `data_atual` datetime NOT NULL DEFAULT current_timestamp(),
  `status` int(11) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_membros`
--

INSERT INTO `tb_membros` (`id_membro`, `nome`, `alcunha`, `telefone1`, `telefone2`, `idade`, `sexo`, `id_morada`, `estado_civil`, `BI_Cedula`, `id_filiacao`, `email`, `facebook`, `areaFormacao`, `nivelEscolar`, `escola`, `ramo`, `profissao`, `id_cargo`, `id_comissao`, `grupo`, `data_nascimento`, `cat_membro`, `classe`, `imagem`, `data_emissao`, `como_ingressou`, `presenca`, `motivo`, `igreja_Anterior`, `funcaoA_Exercer`, `descricao_Organizacao`, `estado`, `data_atual`, `status`) VALUES
(16, 'Lucénia Stela Ngunza Gomes', 'Kelly', 942693609, 995172916, 20, 'Feminino', 28, 'Solteira', '007431081LA049', 15, 'luceniagomes3@gmail.com', 'Lucénia Gomes', 'Análises C e Saúde P', 'Ensino Superior', 'Universidade Metodista de Ango', 'Nenhum', 'Estudante', 25, 14, 'Coral Dos Adolescentes', '2001-08-26', 'Aprova', 'Daniel', '//fotos_jimub//', '2014-07-23', 'Vindo da classe infantil', 'Presente', 'Motivo ', 'Igreja Anterior', 'Presidente de Culto e Música', 'Boa e Instrutiva', 'Vivo', '2021-10-23 15:42:56', 1),
(17, 'Hernania Francisco Ferreira', 'Any', 947879413, 990771581, 21, 'Feminino', 29, 'Solteira', '006173150LA048', 16, 'ferreiraany0@gmail.com', 'Any Ferreira', 'Análise C e Saúde P', 'Ensino Superior', 'Universidade Metodista Angola', 'Nenhum', 'Estudante', 23, 12, 'Nenhum', '2000-04-27', 'Aprova', 'Joaquim Murimba', '//fotos_jimub//', '2015-01-23', 'Outro', 'Presente', 'Motivo ', 'Não tinnha', 'Deseja exercer alguma função na igreja?qual? ', 'O que achas da organização?', 'Vivo', '2021-10-23 16:08:12', 1),
(18, 'Sérgio da Silva', 'Shack Árabe', 945947871, 996145393, 25, 'Masculino', 30, 'Solteiro', '006267994LA041', 17, 'sergiosilva1105@gmail.com', 'Sérgio da Silva', 'Eng. Quimica', 'Ensino Superior', 'ISPTEC', 'Nenhum', 'Estudante', 33, 12, 'Tudizole', '1996-11-05', 'Aprova', 'João Baptista', '//fotos_jimub//', '2010-10-10', 'Vindo da classe infantil', 'Presente', 'Motivo ', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual? ', 'O que achas da organização?', 'Vivo', '2021-10-23 16:37:53', 1),
(20, 'Juelma Clara Francisco Ferreira', 'Juelma', 940885367, 0, 24, 'Feminino', 32, 'Solteira', '005368039LA040', 19, 'clarafranciscoferreira@gmail.com', 'Juelma Clara', 'Odontologia', 'Licenciatura', 'Nenhuma', '', 'Nenhuma', 21, 10, 'Coral Dos Adolescentes', '1997-09-12', 'Efectivo', 'Alberto Neto', '//fotos_jimub//', '2012-10-23', 'Outro', 'Presente', 'Motivo ', 'IMU Rita Webba', 'Não', 'Escola.', 'Vivo', '2021-10-23 16:54:56', 1),
(31, 'Silmara Patricia Vicente Lopes ', 'Lopes', 996575799, 0, 16, 'Feminino', 43, 'Solteira', 'BI/cedula', 30, 'nenhum', 'Silmara Patricia Lopes', 'Eletricidade', 'Ensino Médio', 'são Benedito', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2005-07-27', 'Catecumeno', 'Sebastião Gaspar', '//fotos_jimub//', '2019-10-24', 'Outro', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual? ', 'boa', 'Vivo', '2021-10-24 12:05:34', 1),
(32, 'Isabel Meury Ribeiro Aleixo Jose', 'Pelma', 923508152, 939282840, 16, 'Feminino', 44, 'Solteira', 'Nenhum', 31, 'Nenhum', 'Isabel Ribeiro', 'Nenhuma', 'Ensino Secundário', 'Colegio 1040', 'Nenhum', 'Estudante', 18, 15, 'Nenhum', '2005-01-06', 'Catecumeno', 'Isabel Buta', '//fotos_jimub//', '2021-10-16', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual? ', 'O que achas da organização?\nEu achoa  organização maravilhosa', 'Vivo', '2021-10-24 12:05:51', 1),
(33, 'Albertina De Jesus Teca', 'Nenhum', 923351974, 0, 11, 'Feminino', 45, 'Solteira', 'BI/cedula', 32, 'Nenhuml', 'Nenhum', 'Nenhum', 'Ensino Primário', 'Genix', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2010-12-28', 'Catecumeno', 'Daniel', '//fotos_jimub//', '2021-10-23', 'Convite', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual? ', 'O que achas da organização?', 'Vivo', '2021-10-24 12:10:11', 1),
(34, 'Leticia Alberto Pedro Joaquim', 'Leticia', 923291080, 0, 16, 'Feminino', 46, 'Solteira', 'BI/cedula', 33, 'Nenhum', 'Leticia Joaquim', 'Enfermagem', 'Ensino Médio', 'Colegio Darcan', 'Nenhum', 'Estudante', 18, 15, 'Nenhum', '2005-03-26', 'Aprova', 'Rev. Teodoro Webba', '//fotos_jimub//', '2021-07-01', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual? ', 'Boa e agradavel', 'Vivo', '2021-10-24 12:10:27', 1),
(35, 'Maria Antónia Miguel Fernades', 'Fernandes', 936215265, 0, 24, 'Feminino', 47, 'Solteira', '006032325LA043', 34, 'Nenhuma', 'Tunicha Fernandes', 'Enfermagem', 'Ensino Superior', 'IMS', 'Saúde', 'Enfermeira', 29, 14, 'Coral Dos Adolescentes', '1997-07-21', 'Efectivo', 'Josué', '//fotos_jimub//', '2013-10-24', 'Outro', 'Presente', '', 'Nenhuma', 'Nenhuma', 'Boa', 'Vivo', '2021-10-24 12:16:12', 1),
(36, 'Biatriz Morais Capembe', 'Bia', 934513083, 0, 11, 'Feminino', 48, 'Solteira', 'Nenhum', 35, 'Nenhum', 'Nenhum', 'Ensino Secundario', 'Ensino Primário', 'Colegio Betelem ', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2010-04-21', 'Catecumeno', 'Marcela Da Silva', '//fotos_jimub//', '2021-10-23', 'Convite', 'Presente', '', 'Nenhum', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-24 12:16:27', 1),
(37, 'Raquel Manuela Cosme Lourenco', 'Raquel', 997419729, 928403565, 15, 'Feminino', 49, 'Solteira', 'BI/cedula', 36, 'Nenhum', 'Raquel Lourenco', 'Enfermagem', 'Ensino Médio', 'Colegio Albino', 'Nenhum', 'Estudante', 18, 12, 'Nenhum', '2006-02-22', 'Aprova', 'S.Pedro', '//fotos_jimub//', '2021-09-01', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'Boa ', 'Vivo', '2021-10-24 12:18:07', 1),
(38, 'Margareth Brigete Silva Neto', 'Magda', 928875162, 997233923, 17, 'Feminino', 50, 'Solteira', 'Nenhum', 37, 'Nenhum', 'Margareth Neto Magda', 'Enfermagem', 'Ensino Médio', 'Nossa Senhora Da Anuciação Guarda Lupe ', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2004-08-24', 'Efectivo', 'Jerusalém', '//fotos_jimub//', '2016-10-24', 'Convite', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-24 12:22:51', 1),
(39, 'Paulo Sergio Lourenco Domingos', 'Paulo', 947962837, 937188217, 17, 'Masculino', 51, 'Solteiro', 'BI/cedula', 38, 'Paulojeremiasfilho@gmail.com', 'Nenhum', 'Ciencias economicas e juridicas', 'Ensino Médio', 'Colegio Pitruca', 'Nenhum', 'Estudante', 18, 13, 'Nenhum', '2004-07-25', 'Aprova', 'Elias', '//fotos_jimub//', '2017-01-01', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'Boa', 'Vivo', '2021-10-24 12:24:02', 1),
(40, 'Florinda Lenge Tando', 'Tando', 945026737, 0, 17, 'Feminino', 52, 'Solteira', 'sim', 39, 'FloraLisboaCardoso@gmail.com', 'Floriana Lisboa', 'nenhuma', 'Ensino Secundário', 'Escola 147 ', 'Nenhum', 'Estudante', 18, 13, 'Nenhum', '2004-04-13', 'Aprova', 'Sebastião Gaspar', '//fotos_jimub//', '2015-10-24', 'Outro', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-24 12:24:20', 1),
(41, 'Telmo Da Conscesão Dos Reis ', 'Telson', 990442722, 0, 13, 'Masculino', 53, 'Solteiro', '0', 40, 'Nenhum', 'Telmo PYTREX', 'Ensino Secundario', 'Ensino Secundário', 'Verbo Divino', 'Nenhum', 'Estudante', 18, 13, 'Coral Dos Adolescentes', '2008-10-03', 'Catecumeno', 'Corintios', '//fotos_jimub//', '2021-07-24', 'Convite', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-24 12:28:23', 1),
(42, 'Bernardina Ketania Silva Neto', 'Nadia', 932793711, 925186434, 17, 'Feminino', 54, 'Solteira', 'BI/cedula', 41, 'Bernardinaneto3@gmail.com', 'Bernardina Silva', 'Electronica e Telecomunicacao', 'Ensino Médio', 'Instituto de telecomunicaoes ', 'Nenhum', 'Estudante', 18, 9, 'Nenhum', '2004-08-24', 'Aprova', 'Jerusalém', '//fotos_jimub//', '2020-04-01', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'Seria, com objectivos bem assentes firmados no Senhor', 'Vivo', '2021-10-24 12:29:29', 1),
(43, 'Gildo Dorivaldo Jeronimo De Sousa', 'Sousa', 923394982, 0, 12, 'Masculino', 55, 'Solteiro', '0', 42, 'Nenhum', 'Ermenegilgo Maqueene', 'Nenhum', 'Ensino Secundário', 'Escola 1513', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2009-03-12', 'Catecumeno', 'António Rocha', '//fotos_jimub//', '2021-08-24', 'Outro', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-24 12:30:57', 1),
(44, 'Marcelo Diogo Quissua', 'Marcelo', 943913394, 993104101, 13, 'Masculino', 56, 'Solteiro', 'Nenhum', 43, 'Nenhum', 'Marcelo Diogo', 'Nenhum', 'Ensino Primário', 'Dom Moises', 'Nenhum', 'Estudante', 18, 15, 'Tudizole', '2008-04-13', 'Catecumeno', 'Alberto Neto', '//fotos_jimub//', '2021-10-16', 'Convite', 'Presente', '', 'Igreja Anterior', 'Nenhum', 'Eu acho boa', 'Vivo', '2021-10-24 12:31:27', 1),
(45, 'Micael Wenceslau Boaventura Bessa', 'Mica', 924335200, 0, 14, 'Masculino', 57, 'Solteiro', '0', 44, 'micannany@gmail.com', 'Nenhum', 'Ensino Secundario', 'Ensino Secundário', 'Elisangila Filomena', 'Nenhum', 'Estudante', 18, 9, 'Nenhum', '2007-10-21', 'Efectivo', 'Daniel', '//fotos_jimub//', '2021-07-24', 'Convite', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-24 12:33:43', 1),
(46, 'Henriques Paulo Pimentel de Andrade', 'Erick', 932850737, 922981389, 12, 'Masculino', 58, 'Solteiro', 'BI/cedula', 45, 'Nenhum', 'Nenhum', 'Nenhuma', 'Ensino Secundário', 'Ekuikui II', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2009-07-19', 'Catecumeno', 'Elias', '//fotos_jimub//', '2021-01-01', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'Boa', 'Vivo', '2021-10-24 12:36:03', 1),
(47, 'Wander Leandro Gonçalves', 'Gonçalves', 934909560, 0, 12, 'Masculino', 59, 'Solteiro', '0\r\n0', 46, 'nenhum', 'Wg Gonçalves Leandro', 'Nenhum', 'Ensino Primário', 'Escola Bethelém', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2009-09-13', 'Catecumeno', 'António Rocha', '//fotos_jimub//', '2020-10-24', 'Voluntariamente', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual? ', 'O que achas da organização?', 'Vivo', '2021-10-24 12:37:07', 1),
(48, 'Ana Marisa Borges', 'Toyana', 997018046, 0, 22, 'Feminino', 60, 'Solteira', '006081084LA046', 47, 'anamarisaborge72gmail.com', 'Ana Marisa Borges', 'Direito', 'Ensino Superior', 'Universidade Metodista', 'Nenhum', 'Estudante', 18, 10, 'Tudizole', '1999-09-11', 'Aprova', 'Isabel Buta', '//fotos_jimub//', '2019-01-08', 'Convite', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-24 12:40:15', 1),
(49, 'Euclides Caetano do Nascimento', 'Lintom', 949009307, 914267496, 22, 'Masculino', 61, 'Solteiro', 'Nenhum', 48, 'euclides20nascimento@gmail.com', 'Euclides Nascimento', 'Área de formação', 'Ensino Médio', 'Colegio Santa Ana e Noesa', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '1999-02-23', 'Catecumeno', 'Marcela Da Silva', '//fotos_jimub//', '2021-10-17', 'Voluntariamente', 'Presente', '', 'Igreja Anterior', 'NÃO', 'Eu acho ela boa', 'Vivo', '2021-10-24 12:40:31', 1),
(50, 'Yannis Daniela Boaventura Bessa', 'Nanny', 937578368, 0, 12, 'Feminino', 62, 'Solteira', '0', 49, 'yannisbessa24@gmail.com', 'nenhum', 'Área de formação', 'Ensino Secundário', 'Colegio Elizangela Filomena', 'Nenhum', 'Estudante', 18, 12, 'Nenhum', '2009-03-24', 'Catecumeno', 'Daniel', '//fotos_jimub//', '2021-05-24', 'Convite', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-24 12:43:31', 1),
(51, 'Alice Miguel Fernandes', 'Milena', 940889627, 942787867, 19, 'Feminino', 63, 'Solteira', 'BI/cedula', 50, 'Alicemiguelfernandes@gmail.com', 'Alice Fernandes', 'Ciencias economicas e juridicas', 'Ensino Médio', 'Complexo escolas Sao Domingos Savio', 'Nenhum', 'Estudante', 18, 9, 'Nenhum', '2002-06-06', 'Catecumeno', 'Isabel Buta', '//fotos_jimub//', '2018-01-01', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Secretaria de Informacao', 'Muito boa, saudavel, amaveis e preocupados com o proximo e um local apropriado para se estar', 'Vivo', '2021-10-24 12:44:14', 1),
(52, 'Georgina Camila Luisa Agostinho', 'Tucha', 947999596, 927298002, 16, 'Feminino', 64, 'Solteira', 'Nenhuma', 51, 'Nenhum', 'Lukenia Marcia', 'Contabilidade e gestao', 'Ensino Médio', 'São Benedito', 'Funcionário', 'Cabelereira', 18, 12, 'Nenhum', '2005-02-02', 'Catecumeno', 'António Rocha', '//fotos_jimub//', '2019-02-02', 'Voluntariamente', 'Presente', '', 'Igreja Anterior', 'Secretaria de  Fraternidade', 'Eu acho boa.', 'Vivo', '2021-10-24 12:47:35', 1),
(53, 'Arieth Maria Van-Dúnem Miguel', 'Arinuel', 935094433, 995686705, 15, 'Feminino', 65, 'Solteira', '0', 52, 'ariethmariamiguel@gmail.com', 'Nenhum', 'Ensino Secundario', 'Ensino Secundário', 'Instituto Politecnico Dom Damião FranKlin', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2006-11-27', 'Aprova', 'Nazaré', '//fotos_jimub//', '2021-07-14', 'Outro', 'Presente', '', 'Belem', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-24 12:49:11', 1),
(54, 'Antonio Diogo Manuel', 'Ivan Diogo', 937196060, 923719627, 16, 'Masculino', 66, 'Solteiro', 'BI/cedula', 53, 'ivandiogomanuelivanmanuel@gmail.com', 'Ivan Diogo Diogo', 'Informatica', 'Ensino Médio', 'Colegio Betania', 'Nenhum', 'Estudante', 18, 13, 'Nenhum', '2005-06-02', 'Catecumeno', 'Sebastião Gaspar', '//fotos_jimub//', '2019-01-01', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Secretario de Recreio e Despor', 'Muito boa', 'Vivo', '2021-10-24 12:50:16', 1),
(55, 'conceição José Gomes', 'Sany', 930488314, 0, 16, 'Feminino', 67, 'Solteira', '0', 54, 'TussanySany@gmail.com', 'Tussany Aurora Gomes', 'Área de formação', 'Ensino Secundário', 'Escola 6012', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2005-01-16', 'Aprova', 'Jerusalém', '//fotos_jimub//', '2021-02-24', 'Voluntariamente', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-24 12:50:27', 1),
(56, 'Francelina Casimiro de Sousa ', 'Sousa M3', 924975039, 0, 18, 'Feminino', 68, 'Solteira', 'BI/cedula', 55, 'Nenhum', 'Francelina Sousa', 'Ciências Físicas e Biologicas ', 'Ensino Médio', 'Liceu Rei Mandume', 'Nenhum', 'Estudante', 18, 14, 'Nenhum', '2003-02-24', 'Aprova', 'Isabel Buta', '//fotos_jimub//', '2016-08-24', 'Vindo da classe infantil', 'Presente', '', 'Nunhuma', 'Sim. Professora da E.B.F', 'Boa', 'Vivo', '2021-10-24 12:51:31', 1),
(57, 'Mario Diogo Manue', 'Vava Diogo', 937102083, 923719627, 13, 'Masculino', 69, 'Solteiro', 'BI/cedula', 56, 'Nenhum', 'Mario Diogo Diogo', 'Nenhuma', 'Ensino Secundário', 'Ana Ngola', 'Nenhum', 'Estudante', 18, 13, 'Nenhum', '2008-02-15', 'Catecumeno', 'Sebastião Gaspar', '//fotos_jimub//', '2019-01-28', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Vice Secretario de R.Desporto', 'Muito boa', 'Vivo', '2021-10-24 12:55:54', 1),
(58, 'Luweia Daniela De Oliveira Campos ', 'Luweia', 946382464, 0, 15, 'Feminino', 70, 'Solteira', '0', 57, 'luweiacamposcampos@gmail.com', 'Nenhum', 'Ensino Secundario', 'Ensino Secundário', 'São Domingos ', 'Nenhum', 'Estudante', 18, 13, 'Coral Dos Adolescentes', '2006-11-03', 'Catecumeno', 'António Rocha', '//fotos_jimub//', '2021-07-15', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-24 12:57:08', 1),
(59, 'ISAEL FERREIRA SIMÕES ', 'CLEUSIO', 993340289, 923340289, 14, 'Masculino', 84, 'SOLTEIRO', '020629993LA056', 69, 'NENHUM', 'ISAEL FERREIRA CLEUSIO', 'NENHUMA', 'Ensino Secundário', 'ESCOLA PUBLICA 147', 'Nenhum', 'ESTUDANTE', 18, 13, 'Nenhum', '2007-11-26', 'Aprova', 'Joaquim Murimba', '//fotos_jimub//', '2021-06-09', 'Convite', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual? ', 'ACHO BOA', 'Vivo', '2021-10-24 13:52:12', 1),
(60, 'EBENEZER CARLOS ANTONIO MATEUS', 'FOFO', 922962280, 917320319, 22, 'Masculino', 85, 'Solteiro', '0062633382LA043', 70, 'EBENEZERMATEUSMATEUS2GMAIL.COM', 'EBENEZER CARLOS', 'PSICOLOGIA', 'Ensino Superior', 'UNIVERSIDADE DE BELAS', 'Nenhum', 'ESTUDANTE', 18, 13, 'Coral Dos Adolescentes', '1999-02-09', 'Efectivo', 'Isabel Buta', '//fotos_jimub//', '2015-02-24', 'Vindo da classe infantil', 'Presente', '', 'NENHUMA', 'NENHUM', 'ACHO FIXE', 'Vivo', '2021-10-24 14:01:04', 1),
(61, 'Aguinaldo Patrão Martins Caterça', 'Agui', 938733469, 0, 22, 'Masculino', 86, 'Solteiro', '004991026LA041', 71, 'aguinaldopatrãoagui@gmail.com', 'Aguinaldo Martins Caterça', 'Gestão E Adiministração De Empresas', 'Ensino Superior', 'Universidade Metodista', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '1999-02-10', 'Catecumeno', 'Marcela Da Silva', '//fotos_jimub//', '2021-10-10', 'Convite', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual? ', 'O que achas da organização?', 'Vivo', '2021-10-24 14:03:13', 1),
(62, 'Uriel Alexandre da Silva Goncalves', 'Uriel', 943713595, 0, 12, 'Masculino', 87, 'Solteiro', 'BI/cedula', 72, 'Nenhum', 'Alexandre Goncalves', 'None', 'Ensino Secundário', 'Complexo escolar Sao Domingos Savio', 'Nenhum', 'Estudante', 18, 13, 'Tudizole', '2009-06-16', 'Catecumeno', 'António Rocha', '//fotos_jimub//', '2021-08-01', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Vice secretario de R.Desporto', 'Boa, prudente e ensina os adolescentes a ingressar para a vida adulta com zelo ', 'Vivo', '2021-10-24 14:06:34', 1),
(63, 'Ricardo Daniel de Miranda Carmelino', 'Ricardo', 0, 997010114, 15, 'Masculino', 88, 'Solteiro', 'BI/cedula', 73, 'ricardocarmelino1107@gmail.com', 'Ricardo Carmelino', 'Nenhuma', 'Ensino Secundário', 'Santa Maria Gorett', 'Nenhum', 'Estudante', 18, 13, 'Tudizole', '2006-09-19', 'Catecumeno', 'Joaquim Murimba', '//fotos_jimub//', '2021-03-24', 'Vindo da classe infantil', 'Presente', '', 'Nenhuma', 'Coordenador dos Adolescentes', 'Algo muito produtivo', 'Vivo', '2021-10-24 14:07:34', 1),
(64, 'ARIEL LEANDRO DA COSTA ', 'ARIEL', 923502756, 923961028, 18, 'Masculino', 89, 'Solteiro', 'BI/cedula', 74, 'NENHUM', 'ARIEL LEANDRO DA COSTA', 'ECONOMICAS E JURIDICAS', 'Ensino Médio', 'C.D.S', 'Nenhum', 'ESTUDANTE', 18, 10, 'Coral Dos Adolescentes', '2003-01-02', 'Aprova', 'Marcela Da Silva', '//fotos_jimub//', '2017-03-24', 'Vindo da classe infantil', 'Presente', '', 'NENHUMA', 'SIM1 EVANGELISMO', 'ACHO BOA', 'Vivo', '2021-10-24 14:08:31', 1),
(65, 'Inivaldo Ferreira Simões', 'Cleny', 998022559, 948920888, 16, 'Masculino', 90, 'Solteiro', '020284384LA053', 75, 'inivaldocleny@gmail.com', 'Inivaldo Ferreira', 'Administração Local', 'Ensino Médio', 'IPAS', 'Nenhum', 'Estudante', 18, 13, 'Nenhum', '2005-04-02', 'Aprova', 'Joaquim Murimba', '//fotos_jimub//', '2021-08-22', 'Convite', 'Presente', '', 'Nenhuma', 'Sim.S. de Rec.Desporto ', 'Boa', 'Vivo', '2021-10-24 14:09:14', 1),
(66, 'Aurio Tarjano Ferreira Cazequeza', 'Aurinho', 915655605, 927412202, 22, 'Masculino', 91, 'Solteiro', '007130988LA041', 76, 'auriocazequeza4@gmail.com', 'Aurio Cazequeza ', 'Engenharia De Refinação De Petrólio', 'Ensino Superior', 'Jeam Piaget', 'Nenhum', 'Estudante', 18, 13, 'Coral Dos Adolescentes', '1999-04-18', 'Aprova', 'Isabel Buta', '//fotos_jimub//', '2014-04-17', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-24 14:12:42', 1),
(67, 'Kenedy Junior Sales Candido', 'Kenny', 937513076, 0, 22, 'Masculino', 92, 'Solteiro', 'BI/cedula', 77, 'Kennedycandido97@gmail.com', 'Kennedy Junior', 'Direito', 'Ensino Superior', 'Universidade Metodista de Angola', 'Nenhum', 'Estudante', 18, 9, 'Coral Dos Adolescentes', '1999-06-27', 'Aprova', 'Sebastião Gaspar', '//fotos_jimub//', '2011-01-01', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Secretario,Tesoureiro,Director', 'Uma organizacao seria, com sustentaculo suficiente para instruir adolescentes para a vida adulta.', 'Vivo', '2021-10-24 14:13:33', 1),
(68, 'NEUSA TUCAYANA DAMIÃO MOISES BARROS', 'TUCAYANA', 923815192, 992886393, 25, 'Feminino', 93, 'Casada', 'BI/cedula', 78, 'NEUSATUCAYANADAMIAOMOISES@GMAIL.COM', 'NENHUM', 'DIREITO', 'Ensino Superior', 'UNIVERSIDADE METODISTA DE ANGOLA', 'Nenhum', 'ESTUDANTE', 18, 10, 'Tudizole', '1996-10-21', 'Efectivo', 'João Baptista', '//fotos_jimub//', '2010-01-24', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'SIM! EVANGELISMO', 'ACHO BOA', 'Vivo', '2021-10-24 14:14:05', 1),
(69, 'Bernarda de Fátima Manuel Agostinho', 'Solene', 946860597, 946804587, 19, 'Feminino', 94, 'Solteira', '0', 79, 'Nenhum', 'Solene Manuel Cris', 'Finanças', 'Ensino Médio', 'I.M.C.L.', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2002-12-15', 'Catecumeno', 'Peniel', '//fotos_jimub//', '2016-10-24', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Secretária', 'É uma boa organização', 'Vivo', '2021-10-24 14:17:58', 1),
(70, 'Isaac António Rodrigues Da Costa', 'Isi', 928881899, 0, 23, 'Masculino', 95, 'Solteiro', '005567378LA044', 80, 'dacostaisaac24@gmail.com', 'Isaac Rodrigues Da Costa', 'Engenharia Informática', 'Ensino Superior', 'Instituto Politecnico Superior Tocóista', 'Nenhum', 'Estudante', 27, 13, 'Coral Dos Adolescentes', '1998-10-02', 'Aprova', 'Marcela Da Silva', '//fotos_jimub//', '2012-03-24', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-24 14:18:11', 1),
(71, 'MANUEL ALVISA ADÃO', 'BELGA', 937071743, 992347549, 16, 'Masculino', 96, 'Solteiro', 'BI/cedula', 81, 'MANUELALVISA@GMAIL.COM', 'TXIO BELGA.TB', 'CIENCIAS ECONOMICAS E JURIDICAS', 'Ensino Médio', 'REI MANDUME', 'Nenhum', 'ESTUDANTE', 18, 13, 'Tudizole', '2005-02-04', 'Catecumeno', 'Marcela Da Silva', '//fotos_jimub//', '2021-02-24', 'Convite', 'Presente', '', 'Igreja Anterior', 'SIM! TESOUREIRO', 'ACHO BOA', 'Vivo', '2021-10-24 14:21:51', 1),
(72, 'Sandro Fernando Gonçalves', 'Batata', 940081283, 946109417, 15, 'Masculino', 97, 'Solteiro', 'BI/cedula', 82, 'Nenhum', 'Sandro Gonçalves', 'Nenhuma', 'Ensino Secundário', 'Escola 17 de Setembro', 'Nenhum', 'Estudante', 18, 13, 'Tudizole', '2006-08-30', 'Catecumeno', 'António Rocha', '//fotos_jimub//', '2021-05-20', 'Voluntariamente', 'Presente', '', 'Nenhuma', 'Sim. Director e Coordenador ', 'Boa e educativa.', 'Vivo', '2021-10-24 14:22:24', 1),
(73, 'Lucas Noé Quimbaca', 'Lucas', 931582056, 0, 24, 'Masculino', 98, 'Solteiro', '006797097LA042', 83, 'lucasnoe35@gmail.com', 'Lucas Noé', 'Ciências Económicas e Jurídicas', 'Ensino Médio', 'Licéu 3042', 'Funcionário', 'Canalizador', 22, 10, 'Nenhum', '1997-05-25', 'Catecumeno', 'Daniel', '//fotos_jimub//', '2017-10-24', 'Voluntariamente', 'Presente', '', 'Nenhuma', 'Não.', 'Boa organização', 'Vivo', '2021-10-24 14:23:39', 1),
(74, 'Lauríssea Gabriel De Oliveira Campos', 'Laussania', 924789040, 0, 17, 'Feminino', 99, 'Solteira', '0', 84, 'laurícisseacampos@gmail.com', 'Lauríssea Campos', 'Ciência Fisicas E Biologicas', 'Ensino Médio', 'São Domingos', 'Nenhum', 'Estudante', 18, 12, 'Nenhum', '2004-02-17', 'Catecumeno', 'António Rocha', '//fotos_jimub//', '2021-07-23', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-24 14:25:52', 1),
(75, 'ELZIO GEOVANI DA SILVA GONÇALVES', 'ELZIO', 943713595, 925933459, 14, 'Masculino', 100, 'Solteiro', 'BI/cedula', 85, 'NENHUM', 'ELZIO GONÇALVES', 'GERAL', 'Ensino Secundário', 'SÃO DOMINGOS', 'Nenhum', 'ESTUDANTE', 18, 15, 'Tudizole', '2007-06-29', 'Catecumeno', 'António Rocha', '//fotos_jimub//', '2021-05-24', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'SIM! RECREIO DESPORTO', 'ACHO BOA', 'Vivo', '2021-10-24 14:27:43', 1),
(76, 'Áurea Miriam da Rocha Ramos da Cruz', 'AC', 943655528, 0, 15, 'Feminino', 101, 'Solteira', 'BI/cedula', 86, 'Nenhum', 'Nenhum', 'Nenhuma', 'Ensino Secundário', 'CPC Primeiro', 'Nenhum', 'Estudante', 18, 14, 'Nenhum', '2006-08-22', 'Catecumeno', 'Isabel Buta', '//fotos_jimub//', '2021-04-20', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Sim, Secretária de SSC', 'Caminhando para um bom caminho.', 'Vivo', '2021-10-24 14:29:05', 1),
(77, 'Saciana Maristela Fernandes Garcia', 'Saci', 948134853, 0, 20, 'Feminino', 102, 'Solteira', 'BI/cedula', 87, 'sacianagarcia@gmail.com', 'Saciana Garcia', 'Medicina Geral', 'Ensino Superior', 'UPRA', 'Nenhum', 'Estudante', 18, 10, 'Coral Dos Adolescentes', '2001-11-27', 'Catecumeno', 'Josué', '//fotos_jimub//', '2018-10-24', 'Convite', 'Presente', '', 'Igreja Anterior', 'Não.', 'É boa.', 'Vivo', '2021-10-24 14:30:18', 1),
(78, 'Joana Manuel Neto', 'Jane', 931902658, 0, 17, 'Feminino', 103, 'Solteira', '0', 88, 'Nenhum', 'Janebra Manuel', 'Ciências Humanas ', 'Ensino Médio', '22 De Novembro', 'Nenhum', 'Estudante', 18, 13, 'Nenhum', '2004-02-27', 'Aprova', 'Rev. Teodoro Webba', '', '2021-07-23', 'Convite', 'Presente', '', 'Convite', 'Presente', '', 'Igreja Anterior', '2021-10-24 14:30:39', 1),
(79, 'EUCLIDES ARTUR BARROS ', 'HÉLIO', 924539708, 912171134, 25, 'Masculino', 104, 'Casado', 'BI/cedula', 89, 'EUCLIDESBARRO32@GMAIL.COM', 'EUCLIDES ARTUR BARROS HELIO', 'MEDICINA', 'Ensino Superior', 'UPRA', 'Saúde', 'Enfermeiro', 31, 14, 'Tudizole', '1996-07-07', 'Efectivo', 'João Baptista', '//fotos_jimub//', '2010-01-24', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'NÃO', 'ACHO EM CRESCIMENTO', 'Vivo', '2021-10-24 14:31:50', 1),
(80, 'Edvânia Patrícia Francisco Manuel', 'Nenhuma', 924452061, 0, 14, 'Feminino', 105, 'Solteira', 'BI/cedula', 90, 'Nenhum', 'Nenhum', 'Nenhuma', 'Ensino Secundário', 'Escola 3081', 'Nenhum', 'Estudante', 18, 14, 'Nenhum', '2007-05-30', 'Catecumeno', 'Daniel', '//fotos_jimub//', '2020-01-15', 'Convite', 'Presente', '', 'Igreja Metodista Unida Professora Juliana', 'Sim, Coral dos Adolescentes', 'Boa', 'Vivo', '2021-10-24 14:34:53', 1),
(81, 'Luciano Marçal José', 'Yano', 0, 0, 17, 'Masculino', 106, 'Solteiro', '007795452LA040', 91, 'Nenhum', 'Nenhum', 'Ciências Ficas E Biologicas', 'Ensino Médio', 'Rei Mandume', 'Nenhum', 'Estudante', 18, 13, 'Nenhum', '2004-07-13', 'Catecumeno', 'Marcela Da Silva', '//fotos_jimub//', '2021-07-24', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-24 14:35:16', 1),
(82, 'Pâmela Figueira Dias Dos Santos', 'Pâmela', 949642291, 0, 24, 'Feminino', 108, 'Solteira', 'BI/cedula', 93, 'pameladossantos900@gmail.com', 'Pâmela Figueira Dias Dos Santos', 'Direito', 'Ensino Superior', 'Universidade Metodista de Angola', 'Educação', 'Professora', 32, 15, 'Tudizole', '1997-12-20', 'Efectivo', 'Alberto Neto', '//fotos_jimub//', '2012-10-24', 'Convite', 'Presente', '', 'Igreja Adventista Do Sétimo Dia', 'Não ', 'Boa, edificante, escola.', 'Vivo', '2021-10-24 15:04:21', 1),
(83, 'Ednara Maria Ferreira de Almeida', 'Nara', 936207383, 0, 18, 'Feminino', 109, 'Solteira', '00592742LA047', 94, 'Nenhum', 'Ednara Maria', 'Direito', 'Ensino Superior', 'Universidade Agostinho Neto', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2003-01-26', 'Efectivo', 'Alberto Neto', '//fotos_jimub//', '2018-07-01', 'Voluntariamente', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual? ', 'O que achas da organização?', 'Vivo', '2021-10-24 15:12:54', 1),
(85, 'Winnie Ruth Ambriz Quindai', 'Winnie ', 92235567, 929733941, 22, 'Feminino', 111, 'Solteira', '005898530LA041', 96, 'winniequindai@gmail.com', 'Winnie Quindai', 'Análises Clínicas e  Saúde Pública', 'Ensino Superior', 'Universidade Metodista de Angola', 'Saúde', 'Biomédica', 18, 10, 'Coral Dos Adolescentes', '1999-05-07', 'Efectivo', 'Elias', '//fotos_jimub//', '2013-10-30', 'Vindo da classe infantil', 'Ausente', 'Trabalho', 'Igreja Anterior', 'Não', 'Boa e tem feito muito em prol do desenvolvimento social e espiritual dos jovens.', 'Vivo', '2021-10-30 13:36:20', 1),
(86, 'Alberto Manuel Francisco', 'William', 924290435, 923966407, 24, 'Masculino', 112, 'Solteiro', 'BI/Cedula', 97, 'williamvera072@gmail.com', 'Poeta Wizzy', 'Gestão e Administração de Empresas', 'Ensino Superior', 'Universidade Metodista De Angola', 'Nenhum', 'Estudante', 26, 10, 'Nenhum', '1997-11-02', 'Efectivo', 'Daniel', '//fotos_jimub//', '2012-10-30', 'Voluntariamente', 'Regular', 'Nenhum', 'Igreja Anterior', 'Não ', 'Boa porque ajuda-nos no desenvolvimento espiritual e psicológico.', 'Vivo', '2021-10-30 13:48:45', 1),
(87, 'Sandra Eliane De Carvalho Chaves ', 'Eliane', 929159324, 999159324, 19, 'Feminino', 113, 'Solteira', '004664387LA042', 98, 'Nenhum', 'Eliane De Carvalho', 'Enfermagem', 'Ensino Médio', 'Santa Ana E Noesa', 'Nenhum', 'Estudante', 30, 14, 'Nenhum', '2002-05-01', 'Efectivo', 'Elias', '//fotos_jimub//', '2016-06-21', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual? ', 'O que achas da organização?', 'Vivo', '2021-10-30 14:15:44', 1),
(88, 'Eliane Raquel Afonso Domingos ', 'Vadjy', 923401185, 948858938, 19, 'Feminino', 114, 'Solteira', '00', 99, 'elianevadjynesia@gmail.com', 'Eliane Domingos ', 'Enfermagem', 'Ensino Médio', 'ALPEGA', 'Saúde', 'Enfermeira', 9, 15, 'Coral Dos Adolescentes', '2002-10-13', 'Efectivo', 'Elias', '//fotos_jimub//', '2016-06-21', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual? ', 'O que achas da organização?', 'Vivo', '2021-10-30 14:24:00', 1),
(89, 'Marisol Medine Ferreira Maria', 'Marisol', 932193044, 0, 18, 'Feminino', 115, 'Solteira', '00', 100, 'Nenhum', 'Marisol Medine ', 'Ciências Fisicas e Biologicas', 'Ensino Médio', 'Santa Ana E Noesa ', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2003-03-10', 'Aprova', 'Alberto Neto', '//fotos_jimub//', '2016-06-14', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-30 14:30:41', 1),
(90, 'Bráulio Barbete Francisco Silvestre ', 'Bráulio', 935374861, 923686896, 17, 'Masculino', 116, 'Solteiro', 'BI/cedula', 101, 'Email', 'Bráulio Silvestre Silvestre', 'Técnico de Informática', 'Ensino Médio', 'São Benedito', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2004-06-26', 'Catecumeno', 'Daniel', '//fotos_jimub//', '2017-10-30', 'Voluntariamente', 'Regular', 'Nenhum', 'Não Lembra', 'Deseja exercer alguma função na igreja?qual? ', 'Boa.', 'Vivo', '2021-10-30 14:31:51', 1),
(91, 'Alexandrino Emanuel Jorge Fernando', 'Xandinho', 933910514, 993506162, 19, 'Masculino', 117, 'Solteiro', '005998933LA042', 102, 'alexandrinofernandoxandinho@gmail.com', 'Alexandre Jorge', 'Ciências Físicas e Biológicas', 'Ensino Superior', 'Complexo Escolar São Domingos', 'Nenhum', 'Estudante', 24, 9, 'Coral Dos Adolescentes', '2002-08-16', 'Efectivo', 'Josué', '//fotos_jimub//', '2016-08-30', 'Vindo da classe infantil', 'Regular', 'Nenhum', 'Igreja Anterior', 'Não', 'Boa', 'Vivo', '2021-10-30 14:38:26', 1),
(92, 'Rossana Maria Buta Lidador', 'Rossana', 929954488, 947153037, 15, 'Feminino', 118, 'Solteira', '00', 103, 'Nenhum', 'Nenhum', 'Ciências Economicas e Juridicas ', 'Ensino Médio', 'São Jose De Cluny', 'Nenhum', 'Maquidora/Estudante ', 18, 9, 'Coral Dos Adolescentes', '2006-05-23', 'Aprova', 'Isabel Buta', '//fotos_jimub//', '2021-07-06', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-30 14:39:53', 1),
(93, 'Arzubela Da Gloria Cristovão Zua', 'Zu', 936263163, 990263163, 17, 'Feminino', 119, 'Solteira', '006426768ME041', 104, 'zubelazua@gmail.com', 'Nenhuma ', 'Enfermagem', 'Ensino Médio', 'Bendizer ', 'Nenhum', 'Estudante', 18, 10, 'Coral Dos Adolescentes', '2004-03-31', 'Catecumeno', 'S.Pedro', '//fotos_jimub//', '2019-06-12', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-30 14:49:09', 1),
(94, 'Anica José Fernades', 'Nizandra', 947113347, 0, 21, 'Feminino', 120, 'Solteira', '008770241LA048', 105, 'Nenhum', 'Anica Fernades', 'Fisioterapia', 'Ensino Superior', 'Universidade Metodista', 'Nenhum', 'Estudante', 28, 13, 'Coral Dos Adolescentes', '2000-01-18', 'Aprova', 'Peniel', '//fotos_jimub//', '2016-06-14', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-30 15:03:30', 1),
(95, 'Marinela Preciosa Da Silva Catumbila', 'Marinela', 912167290, 923962530, 19, 'Feminino', 121, 'Solteiro', '005714935LA046', 106, 'marinelap.d.s.katumbila@gmail.com', 'Marinela Preciosa', 'Eng.Química', 'Ensino Superior', 'ISPTEC', 'Nenhum', 'Estudante', 34, 15, 'Nenhum', '2002-12-21', 'Catecumeno', 'Josué', '//fotos_jimub//', '2016-10-30', 'Voluntariamente', 'Regular', 'Nenhum', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual? ', 'O que achas da organização?', 'Vivo', '2021-10-30 15:06:54', 1),
(96, 'Eclésio Da Graça Dos Santos Francisco ', 'Cle', 939571499, 936783018, 22, 'Masculino', 122, 'Solteiro', '005522816LA045', 107, 'eclesiodossantos99@gmail.com', 'Eclésio Francisco', 'Psicologia ', 'Ensino Superior ', 'Universidade Metodista', 'Nenhum', 'Estudante ', 18, 12, 'Nenhum', '1999-03-10', 'Efectivo', 'Damasco', '//fotos_jimub//', '2017-02-06', 'Outro', 'Presente', '', 'Igreja Metodista Unida Centra do Uambo ', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-30 15:11:20', 1),
(97, 'Joana Manuela António', 'Joana', 922740164, 922702610, 24, 'Feminino', 123, 'Solteira', 'BI/cedula', 108, 'Email', 'Joana Manuela António', 'Enfermagem', 'Ensino Médio', 'Cital de Base', 'Nenhum', 'Estudante', 20, 10, 'Nenhum', '1997-02-13', 'Efectivo', 'Isabel Buta', '//fotos_jimub//', '2015-10-30', 'Voluntariamente', 'Regular', 'Nenhum', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual? ', 'O que achas da organização?', 'Vivo', '2021-10-30 15:13:15', 1),
(98, 'Domingas Gimbo', 'Lene', 944697386, 0, 18, 'Feminino', 124, 'Solteira', '00', 109, 'Nenhuma', 'Domingas Gimbo', 'Enfermangem', 'Ensino Médio', 'Mara e Lú', 'Nenhum', 'Estudante', 18, 10, 'Coral Dos Adolescentes', '2003-05-20', 'Catecumeno', 'Rev. Teodoro Webba', '//fotos_jimub//', '2021-07-15', 'Outro', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-30 15:20:33', 1),
(99, 'Juliana Juelma Dos Santos Panzo', 'Júlia', 933025673, 0, 20, 'Feminino', 125, 'Solteiro', 'BI/cedula', 110, 'Email', 'Não tem', 'Nenhum', 'Ensino Secundário', 'Sagrada Esperança', 'Nenhum', 'Estudante', 18, 8, 'Coral Dos Adolescentes', '2001-10-11', 'Catecumeno', 'Nenhuma', '//fotos_jimub//', '2021-06-30', 'Evangelizado', 'Regular', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual? ', 'O que achas da organização?', 'Vivo', '2021-10-31 12:19:54', 1),
(100, 'Chelsia Eduarda Tondela Katanga', 'Nenhuma', 921219053, 949735396, 15, 'Feminino', 126, 'Solteira', 'BI/cedula', 111, 'Email', 'Marcia Tondela ', 'Nenhum', 'Ensino Secundário', 'Juventude em luta ', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2006-07-31', 'Aprova', 'Rev. Teodoro Webba', '//fotos_jimub//', '2021-09-05', 'Evangelizado', 'Regular', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-31 12:28:37', 1),
(101, 'Olga Solene Manuel Vicente', 'Olga', 923281232, 998084292, 13, 'Feminino', 127, 'Solteira', 'BI/cedula', 112, 'Email', 'Não', 'Nenhum', 'Ensino Secundario', 'Colegio Loide Laura', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2008-09-16', 'Catecumeno', 'Daniel', '//fotos_jimub//', '2021-10-11', 'Vindo da classe infantil', 'Regular', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual? ', 'O que achas da organização?', 'Vivo', '2021-10-31 12:41:29', 1),
(102, 'Suzete Cristina Gerônimo Augusto', 'Suzete', 924537228, 0, 13, 'Feminino', 128, 'Solteira', 'BI/cedula', 113, 'Email', 'Suzete Cristina', 'nenhum', 'ensino secúndario', 'escola grande da terra nova', 'Nenhum', 'Estudante', 18, 12, 'Nenhum', '2008-04-10', 'Catecumeno', 'António Rocha', '//fotos_jimub//', '2021-09-07', 'Convite', 'Irregular', 'Nenhum', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual? ', 'O que achas da organização?', 'Vivo', '2021-10-31 12:59:01', 1),
(103, 'Melve Marques', 'Melve', 928202385, 941343273, 17, 'Masculino', 129, 'Solteiro', '009092323LA042', 114, 'email', 'Melve Marques', 'Ciencias fisicas e biologica', 'Ensino Medio', '22 de novembro', 'Nenhum', 'Estudante', 18, 10, 'Coral Dos Adolescentes', '2004-06-20', 'Catecumeno', 'João Baptista', '//fotos_jimub//', '2019-01-20', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Sim.', 'O que achas da organização?', 'Vivo', '2021-10-31 13:08:27', 1),
(104, 'Wander Ferreira', 'nenhuma', 923344747, 923344747, 15, 'Masculino', 130, 'Solteiro', '007908860LA041', 115, 'Email', 'facebook', 'nenhuma', 'Ensino secúndario', '17 de setembro', 'Nenhum', 'Estudante', 18, 15, 'Nenhum', '2006-02-26', 'Catecumeno', 'Elias', '//fotos_jimub//', '2021-01-16', 'Vindo da classe infantil', 'Regular', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual? ', 'O que achas da organização?', 'Vivo', '2021-10-31 13:16:27', 1),
(105, 'Joelson Ferreira', 'Joel', 923344747, 923344747, 18, 'Masculino', 131, 'Solteiro', '007918710LA042', 116, 'Email', 'Joel Adriano Ferreira', 'Ciências fisicas e biologicas', 'Ensino Médio', 'são domingos', 'Nenhum', 'Estudante', 18, 15, 'Coral Dos Adolescentes', '2003-01-11', 'Catecumeno', 'Elias', '//fotos_jimub//', '2019-01-12', 'Vindo da classe infantil', 'Regular', '', 'Igreja Anterior', 'sim', 'O que achas da organização?', 'Vivo', '2021-10-31 13:22:35', 1),
(106, 'Stiviandra Dias', 'Stivi', 995903094, 927283860, 15, 'Masculino', 132, 'Solteiro', '008542518LA049', 117, 'Email', 'facebook', 'Gestão Empresa', 'Ensino Médio', 'Santa e Noesia', 'Nenhum', 'Estudante', 18, 12, 'Nenhum', '2006-02-27', 'Catecumeno', 'Elias', '//fotos_jimub//', '2021-01-30', 'Vindo da classe infantil', 'Irregular', 'Nenhum', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-31 13:29:30', 1),
(107, 'Ivania dos Santos', 'Iva', 924503820, 924503820, 11, 'Feminino', 133, 'Solteira', 'BI/cedula', 118, 'Email', 'Não tem', 'Área de formação', 'Ensino primario', 'Santa Catarina', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2010-05-31', 'Catecumeno', 'Elias', '//fotos_jimub//', '2021-11-30', 'Convite', 'Irregular', 'Nenhum', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-31 13:37:59', 1),
(108, 'Jucira Raquel Ferreira', 'Deusa', 923423105, 0, 14, 'Feminino', 134, 'Solteira', 'NENHUMA', 119, 'nenhum', 'DEUSA Ferreira Jucira', 'nenhuma', 'Ensino Secundário', 'Juventude em Luta', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2007-05-12', 'Catecumeno', 'Alberto Neto', '//fotos_jimub//', '2021-06-06', 'Vindo da classe infantil', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-31 13:49:10', 1),
(109, 'Joel Dias Anselmo', 'Júnior', 946203197, 0, 25, 'Masculino', 135, 'Casado', '0056364667LA041', 120, 'nenhum', 'Joel Anselmo', 'Tecnologia Mecânica', 'Ensino Médio', 'Makarengo ', 'Nenhum', 'Tecnico Mecânico', 18, 9, 'Coral Dos Adolescentes', '1996-04-26', 'Efectivo', 'Corintios', '//fotos_jimub//', '2013-06-01', 'Voluntariamente', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-31 14:04:34', 1),
(110, 'Ana Carla Menezes Caetano', 'Ana Carla', 922894126, 0, 22, 'Feminino', 136, 'Casada', '007429960LA048', 121, '0', 'Carla Nezes', 'Ciência econômica e Jurídica', 'Ensino Médio', 'Cólegio Vila Flor da Silva', 'Nenhum', 'Esteticista', 18, 15, 'Coral Dos Adolescentes', '1999-06-01', 'Aprova', 'Corintios', '//fotos_jimub//', '2013-06-01', 'Vindo da classe infantil', 'Irregular', 'Nenhum', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-31 14:20:33', 1),
(111, 'Leonor Balduíno Mateus', 'Mateus', 924858973, 924858973, 23, 'Feminino', 137, 'Solteira', '003750803LA035', 122, 'leonornumeli@49gmail.com', 'Leonor Numeli', 'Psicologia', 'Ensino Superior', 'Puniv', 'Nenhum', 'Consultor de vendas', 18, 12, 'Coral Dos Adolescentes', '1998-02-01', 'Catecumeno', 'Isaias', '//fotos_jimub//', '2016-04-01', 'Voluntariamente', 'Presente', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-10-31 14:47:11', 1),
(112, 'Mara Jaqueline Da Silva Felisberto ', 'Mara', 930110855, 922096735, 17, 'Feminino', 138, 'Solteira', 'BI/cedula', 123, 'Email', 'Mara Marcoste', 'Ciencias Economicas e Jurídicas', 'Ensino Médio', 'São Domingos', 'Nenhum', 'Estudante', 18, 10, 'Coral Dos Adolescentes', '2004-02-19', 'Aprova', 'Nazaré', '//fotos_jimub//', '2016-11-07', 'Voluntariamente', 'Regular', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual? ', 'O que achas da organização?', 'Vivo', '2021-11-07 11:42:50', 1),
(113, 'Flora Cassua Nhanga ', 'Filo', 938211004, 923502133, 13, 'Feminino', 139, 'Solteira', 'BI/cedula', 124, 'Email', 'Não tem', 'Nenhuma', 'Ensino Secundário', 'Colégio 3081', 'Nenhum', 'Estudante', 18, 9, 'Nenhum', '2008-07-08', 'Catecumeno', 'Daniel', '//fotos_jimub//', '2021-04-07', 'Vindo da classe infantil', 'Regular', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual? ', 'O que achas da organização?', 'Vivo', '2021-11-07 11:49:58', 1),
(114, 'Weza Kidi Clemente Do Amaral Gourjel', 'Weza', 928403892, 0, 19, 'Feminino', 140, 'Solteira', 'BI/cedula', 125, 'Email', 'Wilma Esma', 'Enfermagem', 'Ensino Médio', 'INS', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2002-08-04', 'Catecumeno', 'Daniel', '//fotos_jimub//', '2016-11-07', 'Vindo da classe infantil', 'Regular', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-11-07 11:54:44', 1),
(115, 'Dwigila Mirian Morais Webba ', 'Dwigila', 922964642, 912584827, 14, 'Feminino', 141, 'Solteira', 'BI/cedula', 126, 'Email', 'Não Tem', 'Nenhuma', 'Ensino Secundário', 'Beata Ana Maria Javouhey', 'Nenhum', 'Estudante', 18, 14, 'Nenhum', '2007-11-24', 'Catecumeno', 'Joaquim Murimba', '//fotos_jimub//', '2021-08-07', 'Vindo da classe infantil', 'Irregular', 'Nenhum', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-11-07 12:01:22', 1),
(116, 'Kélcia Jandira E Silva Cassule', 'Kélcia', 946354976, 924498630, 18, 'Feminino', 142, 'Solteira', '007103113LA045', 127, 'Email', 'Jandira Soares', 'Desenhador Projectista', 'Ensino Médio', 'Macarenco', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2003-05-10', 'Catecumeno', 'Nazaré', '//fotos_jimub//', '2014-06-07', 'Vindo da classe infantil', 'Irregular', 'Nenhum', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-11-07 12:07:05', 1),
(117, 'Vita Mauro', 'Mauro', 928965202, 938415441, 19, 'Masculino', 143, 'Solteiro', 'BI/cedula', 128, 'Email', 'Vita Mauro', 'Ciências Físicas e Biológicas', 'Ensino Médio', 'Liceu 3043- Escola Grande', 'Nenhum', 'Estudante', 18, 10, 'Nenhum', '2002-04-04', 'Catecumeno', 'Corintios', '//fotos_jimub//', '2021-05-07', 'Voluntariamente', 'Regular', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-11-07 12:13:35', 1),
(118, 'Filipe Lisboa', 'Filipe', 930260125, 929688755, 20, 'Masculino', 144, 'Solteiro', '005964039LA040', 129, 'Email', 'Filipe Lisboa', 'Mecatrónica de Automóvel', 'Ensino Médio', 'Makarenco-ipil', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2001-08-12', 'Catecumeno', 'Corintios', '//fotos_jimub//', '2021-11-06', 'Voluntariamente', 'Regular', '', 'Bom Deus', 'Deseja exercer alguma função na igreja?qual? ', 'O que achas da organização?', 'Vivo', '2021-11-07 12:19:12', 1),
(119, 'Ana Da Silva', 'Ana', 947921438, 912935350, 19, 'Feminino', 145, 'Solteira', 'BI/cedula', 130, 'Email', 'Ana Da Silva', 'Contablidade e Administração', 'Ensino Superior', 'ISTA', 'Nenhum', 'Estudante', 18, 15, 'Nenhum', '2002-02-11', 'Catecumeno', 'Josué', '//fotos_jimub//', '2017-11-07', 'Voluntariamente', 'Regular', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-11-07 12:23:09', 1),
(120, 'Rosária Clemente Quindai', 'YaTelma', 929733941, 922385567, 13, 'Feminino', 146, 'Solteira', 'BI/cedula', 131, 'Email', 'Não tem', 'Não tem', 'Ensino Secundário', '9019', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2008-01-27', 'Catecumeno', 'Elias', '//fotos_jimub//', '2021-09-07', 'Vindo da classe infantil', 'Regular', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-11-07 12:28:43', 1),
(121, 'Joana Priscíla Domingos Adão', 'Priscila', 940391142, 935732426, 17, 'Feminino', 147, 'Solteira', 'BI/cedula', 132, 'Email', 'Priscila Domingos Adão', 'Ciencias Físicas e Biológicas', 'Ensino Médio', 'Pai Valiceu', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2004-01-29', 'Aprova', 'Peniel', '//fotos_jimub//', '2015-11-07', 'Vindo da classe infantil', 'Irregular', 'Nenhum', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-11-07 12:34:26', 1),
(122, 'Beatriz Nayara Ferreira kunateke ', 'Bia', 925197593, 923356991, 16, 'Feminino', 148, 'Solteira', 'BI/cedula', 133, 'Email', 'Beatriz Nayara Kunatete', 'Contablidade', 'Ensino Médio', 'ITAS(IMEKK)', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2005-07-22', 'Catecumeno', 'Alberto Neto', '//fotos_jimub//', '2020-11-07', 'Vindo da classe infantil', 'Irregular', 'Nenhum', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual? ', 'O que achas da organização?', 'Vivo', '2021-11-07 12:39:35', 1),
(123, 'Pedro Evanildo Pascoal Francisco', 'Pedro', 948107390, 926386644, 16, 'Masculino', 149, 'Solteiro', 'BI/cedula', 134, 'Email', 'Evanildo Francisco FZY', 'Contablidade', 'Ensino Médio', 'IMEKK', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2005-05-02', 'Catecumeno', 'Daniel', '//fotos_jimub//', '2020-09-07', 'Vindo da classe infantil', 'Regular', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-11-07 12:43:52', 1),
(124, 'Ana Carina José Da Cruz', 'Toya', 924915488, 924671116, 16, 'Feminino', 150, 'Solteira', 'BI/cedula', 135, 'Email', 'Ana Carina José', 'Ciencias Economicas e Jurídicas', 'Ensino Médio', 'Rei Mandume', 'Nenhum', 'Estudante', 18, 12, 'Nenhum', '2005-06-05', 'Catecumeno', 'António Rocha', '//fotos_jimub//', '2018-11-07', 'Vindo da classe infantil', 'Regular', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-11-07 12:49:58', 1),
(125, 'Bernardeth José Garcia', 'Belmira', 946230791, 0, 14, 'Feminino', 151, 'Solteira', 'BI/cedula', 136, 'Email', 'Belmira Costa', 'Nenhuma', 'Ensino Secundário', '17 de Septembro', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2007-08-24', 'Catecumeno', 'Marcela Da Silva', '//fotos_jimub//', '2021-07-07', 'Vindo da classe infantil', 'Regular', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual? ', 'O que achas da organização?', 'Vivo', '2021-11-07 13:00:43', 1),
(126, 'Selene Patrícia Ngunza ', 'Selene', 922216390, 0, 14, 'Feminino', 152, 'Solteira', 'BI/cedula', 137, 'Email', 'Silenny Patricia', 'Nenhuma', 'Ensino Secundário', 'Escola nº 1513', 'Nenhum', 'Estudante', 18, 9, 'Coral Dos Adolescentes', '2007-12-01', 'Aprova', 'Daniel', '//fotos_jimub//', '2021-03-01', 'Vindo da classe infantil', 'Regular', '', 'Igreja Anterior', 'Sim. Secretária de Informação', 'É boa. ', 'Vivo', '2021-11-07 13:04:09', 1),
(127, 'Sara Isabel Marçal', 'Sara', 923577987, 928049394, 16, 'Feminino', 153, 'Solteira', 'BI/cedula', 138, 'Email', 'Jusara', 'Nenhuma', 'Ensino Secundário', '17 de Septembro', 'Nenhum', 'Estudante', 18, 15, 'Nenhum', '2005-03-12', 'Aprova', 'Marcela Da Silva', '//fotos_jimub//', '2020-11-07', 'Vindo da classe infantil', 'Regular', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-11-07 13:05:44', 1),
(128, 'Iranela Jandira de Oliveira Jorge', 'Ira', 929613733, 0, 15, 'Feminino', 154, 'Solteira', 'BI/cedula', 139, 'iranelajorge@gmail.com', 'Iranela Jandira', 'Petroquímica', 'Ensino Médio', 'São Benedito', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2006-05-01', 'Catecumeno', 'Jerusalém', '//fotos_jimub//', '2021-03-01', 'Vindo da classe infantil', 'Regular', '', 'Igreja Anterior', 'Tesoureira  ', 'É boa.', 'Vivo', '2021-11-07 13:09:51', 1),
(129, 'Helena Suraya Gonçalves Calumba', 'Leny', 940081283, 946109417, 22, 'Feminino', 155, 'Solteira', '006397467LA044', 140, 'Email', 'Leryvania Gonçalves', 'Nutrição', 'Ensino Superior', 'Universidade de Belas', 'Nenhum', 'Estudante', 18, 12, 'Coral Dos Adolescentes', '1999-04-05', 'Aprova', 'António Rocha', '//fotos_jimub//', '2014-11-07', 'Vindo da classe infantil', 'Regular', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual?', 'O que achas da organização?', 'Vivo', '2021-11-07 13:11:24', 1);
INSERT INTO `tb_membros` (`id_membro`, `nome`, `alcunha`, `telefone1`, `telefone2`, `idade`, `sexo`, `id_morada`, `estado_civil`, `BI_Cedula`, `id_filiacao`, `email`, `facebook`, `areaFormacao`, `nivelEscolar`, `escola`, `ramo`, `profissao`, `id_cargo`, `id_comissao`, `grupo`, `data_nascimento`, `cat_membro`, `classe`, `imagem`, `data_emissao`, `como_ingressou`, `presenca`, `motivo`, `igreja_Anterior`, `funcaoA_Exercer`, `descricao_Organizacao`, `estado`, `data_atual`, `status`) VALUES
(130, 'Mário Paulo Neto', 'Mano', 941910789, 0, 17, 'Masculino', 156, 'Solteiro', 'BI/cedula', 141, 'Email', 'Mario AO', 'Construção Civíl', 'Ensino Médio', 'Macarenco', 'Nenhum', 'Estudante', 18, 8, 'Nenhum', '2004-08-12', 'Catecumeno', 'Elias', '//fotos_jimub//', '2019-11-07', 'Vindo da classe infantil', 'Regular', '', 'Igreja Anterior', 'Deseja exercer alguma função na igreja?qual? ', 'O que achas da organização?', 'Vivo', '2021-11-07 13:16:16', 1),
(131, 'Ana Cainara Lourenço Camutari', 'Anira', 942752701, 0, 17, 'Feminino', 157, 'Solteira', '00665067LA047', 142, 'Email', 'Ana Gomes', 'Enfermagem', 'Ensino Médio', 'ETESAL Alpega', 'Nenhum', 'Estudante', 18, 10, 'Coral Dos Adolescentes', '2004-04-01', 'Aprova', 'S.Pedro', '//fotos_jimub//', '2019-11-07', 'Vindo da classe infantil', 'Regular', '', 'Igreja Anterior', 'Não.', 'É boa. Mas deveria ter mais acompanhamento', 'Vivo', '2021-11-07 13:23:12', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_mensagem`
--

CREATE TABLE `tb_mensagem` (
  `id_mensagem` int(100) NOT NULL,
  `id_membro` int(100) NOT NULL,
  `id_actividade` int(100) NOT NULL,
  `descricao` varchar(200) CHARACTER SET utf8 NOT NULL,
  `data_atual` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_mes`
--

CREATE TABLE `tb_mes` (
  `id_mes` int(100) NOT NULL,
  `id_membro` int(100) NOT NULL,
  `mes` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_mes`
--

INSERT INTO `tb_mes` (`id_mes`, `id_membro`, `mes`) VALUES
(1, 8, 'Janeiro'),
(2, 8, 'Fevereiro'),
(78, 9, 'Janeiro');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_morada`
--

CREATE TABLE `tb_morada` (
  `id_morada` int(100) NOT NULL,
  `bairro` varchar(100) NOT NULL,
  `rua` varchar(100) NOT NULL,
  `descricao_casa` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_morada`
--

INSERT INTO `tb_morada` (`id_morada`, `bairro`, `rua`, `descricao_casa`) VALUES
(28, 'Tala-Hady', 'Rua H', 'Casa nº 14'),
(29, 'São Paulo', 'Gil Liberdade', 'Prédio 306 2º andar Ap 12'),
(30, 'Marçal', 'Balnearios', 'Nº150'),
(32, 'Avenida Hoji ya Henda', 'Avenida Brasil', 'Prédio 21'),
(43, 'São Paulo', 'Kicombo', 'aptD 07'),
(44, 'Vila Alice', 'Anteiro do Quintal', 'nº25'),
(45, 'Viana', 'Bairro do Milenio', 'Nenhum'),
(46, 'Viana', 'Condominio da Policia, Luanda Sul', '113'),
(47, 'Rangel', 'Dili', 'Casa nº221'),
(48, 'Jumbo', 'Nenhum', 'Nenhum'),
(49, 'Samba', '1 de dezembro', 'Nao sabe'),
(50, 'Viana', ' Pingo De Água', 'Nenhum'),
(51, 'Zango 0', 'zona 3 bloco 1', 'predio 2 apt 1105'),
(52, 'Escombatentes', 'Comandante Válodia', 'Casa nº31'),
(53, 'Rangel', 'Precol', '67'),
(54, 'Viana, 4 de abril', 'Rua 1', 'Nenhum'),
(55, 'Palanca', 'A', 'Nenhum'),
(56, 'Rangel', 'Nelito soares', '25'),
(57, 'Mainga', 'Rua Manuel Pombo', '0'),
(58, 'Rangel', 'Rua da vaidade', '16'),
(59, 'Rangel', 'Colombia', 'Casa nº 10'),
(60, 'Vida Passifica', 'Nenhuma', '10103'),
(61, 'Rangel', 'pica pau', '33'),
(62, 'Mainga', 'Padre Manuel Ruela do Pombo', 'nenhum'),
(63, 'Cazenga', 'Rua Ngola Kiluanje', 'CN2 Zona 1'),
(64, 'Rangel', 'Dona Amalha', 'nenhum'),
(65, 'Rangel', 'Nenhum', 'Nenhum'),
(66, 'Sao Paulo', 'Cristiano dos Santos', 'Predio 107, apt 11'),
(67, 'Rangel', 'C11 de Cima', 'casa nº 42'),
(68, 'Rangel', 'Perna Mbuco', 'Nenhum'),
(69, 'Sao Paulo', 'Cristiano dos Santos', 'predio 107, apt 11'),
(70, 'Ingombota', 'Rainha Ginga', '12'),
(71, 'Marçal ', 'Epal', 'Nenhuma'),
(72, 'Bairro Popular', 'Alves Canela', '68'),
(73, 'Bairro Popular', 'Alves Canela', '68'),
(74, 'Bairro Popular', 'Alves Canela', '68'),
(75, 'Bairro Popular', 'Alves Canela', '68'),
(76, 'Bairro Popular', 'Alves Canela', '68'),
(77, 'Bairro Popular', 'Alves Canela', '68'),
(78, 'Bairro Popular', 'Alves Canela', '68'),
(79, 'Bairro Popular', 'Alves Canela', '68'),
(80, 'MARÇAL', 'RUA DE OLIVENÇA', '034'),
(81, 'MARÇAL', 'RUA DE OLIVENÇA', '034'),
(82, 'MARÇAL', 'RUA DE OLIVENÇA', '034'),
(83, 'MARÇAL', 'RUA DE OLIVENÇA', '034'),
(84, 'RANGEL', 'BRIGADA', '0435'),
(85, 'RANGEL', 'C6 DE BAIXO', '15E'),
(86, 'Rangel', 'Bairro Augusto', '8'),
(87, 'Cassequel do buraco', 'Rua 61', 'Nao sabe'),
(88, 'Marçal', 'Dona Zita', 'Nenhum'),
(89, 'NOVA VIDA', 'SIMIONE', '045'),
(90, 'Rangel', 'Rua da Brigada', '0'),
(91, 'Terra Nova', 'Ilha Da Madeira', '11'),
(92, 'Marcal', 'Rua Coroneis', 'None'),
(93, 'RANGEL', 'DONA AMALIA', '0432'),
(94, 'Adriano Moreira', 'Rua 3 dos Prédios', '0'),
(95, 'Nova Vida', 'Simione', 'Nenhuma'),
(96, 'RANGEL', 'PICA PAU', '11'),
(97, 'Rangel', 'Rua 4', 'Casa Nº10'),
(98, 'Tala-Hady', 'Rua G', '38'),
(99, 'Imgombota', 'Rainha Ginga', '12'),
(100, 'CASSEQUEL', 'RUA DO RAUL', '13'),
(101, 'Bairro Popular', 'Rua Alves Canela', '68'),
(102, 'Golf 2', 'Rua 6', '0'),
(103, 'Cassenda', 'Rua 15', 'Nº 71'),
(104, 'RANGEL', 'DONA AMALIA', '098'),
(105, 'Bairro Cazenga', 'Rua do comércio', 'Nenhuma'),
(106, 'Rangel', 'Rua Da Lama', 'Nenhuma'),
(107, 'CAZENGA', '60', '23'),
(108, 'Vila Alice', 'Vila Alice', '54'),
(109, 'Avenida Hoji Ya Henda ', 'Avenida Brasil', 'Prédio 21, AP 3º andar Direito'),
(110, 'testebairro', 'testerua', 'testecasa'),
(111, 'Camama', 'Militar', 'Não lembra'),
(112, 'Cazenga', 'Tala Hady rua G', '46'),
(113, 'São Paulo', 'Rua Benguela', 'Nenhum'),
(114, 'Cazenga', 'Emissora ', 'Nenhum'),
(115, 'Caciquel', 'Rua 50', 'Nenhuma'),
(116, 'Cazenga', 'Tala Hadi Rua 14', 'Não sabe'),
(117, 'Rangel', 'Dili', '221'),
(118, 'São Paulo', 'Rua Do Lubito ', '65'),
(119, 'Nelito Soares ', 'Avinida Hoje Ya Henda', 'Bloco 25 Apartamento Nº 10'),
(120, 'Cuca', 'Adriano Moreira ', 'Casa Nº 10'),
(121, 'Rangel', 'Ngongo', 'não sabe'),
(122, 'Golf 1', 'Rua 18', 'Nenhuma'),
(123, 'Nelito Soares', '18', '2'),
(124, 'Maianga', 'Nenhum', 'Nº'),
(125, 'Rangel', 'Dili', 'Não sabe'),
(126, 'Cassequel do buraco', 'Cassequel Teixeira ', 'Rua 42'),
(127, 'Rangel', '23', 'Não sabe'),
(128, 'Cazenga/tala hady', 'Rua A', '0'),
(129, 'Rangel', 'Rua da Vaidade', '57'),
(130, 'Rangel', 'Dona malh', '20'),
(131, 'Range', 'Dona Malha', '20'),
(132, 'Rangel', 'Rua do paraná', '17'),
(133, 'Valodia', 'nenhum', '138'),
(134, 'Jumbo', 'NENHUMA', 'NENHUMA'),
(135, 'Rangel', 'Rua do Mata Gato', 'nº2'),
(136, 'Rangel', 'Rua do Paraná', 'nº28'),
(137, 'Patrício', 'Patricío', 'nº18'),
(138, 'Rangel', 'Bairro augustu', 'Nº2'),
(139, 'Tala Hady(vila-flor)', '17', '13'),
(140, 'Tala Hady', 'J', '69'),
(141, 'Viana', 'Condomínio Girassol', '1374'),
(142, 'Nova Vida', '105', 'E145'),
(143, 'Rangel', 'Paraná', 'Não'),
(144, 'Rangel', 'Paraná', 'Caputo'),
(145, 'Rangel', 'Paraná', 'Ambaca'),
(146, 'Camama', 'Direita do Mundo novo', 'Não sabe'),
(147, 'Viana', 'não tem', 'Não tem'),
(148, 'Sapu', 'Não sabe', 'Não sabe'),
(149, 'Cazenga-Tala Hady', 'H', 'Não sei'),
(150, 'Rangel', 'Do Povo', '22'),
(151, 'Rangel', 'Ambaca', 'Não tem'),
(152, 'Tala Hady', 'Rua H', '0'),
(153, 'Rangel', 'Ambaca', 'Não sabe'),
(154, 'Bairro Popular', 'Josefa De Óbido', '0'),
(155, 'Rangel', '4', '9'),
(156, 'Rangel', 'Bar Reis', 'Não sabe'),
(157, 'Marçal', 'Rua da Brigada', 'nº9 Zona 14');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_patrimonio`
--

CREATE TABLE `tb_patrimonio` (
  `id_patrimonio` int(100) NOT NULL,
  `id_comissao` int(100) NOT NULL,
  `descricao` varchar(200) CHARACTER SET utf8 NOT NULL,
  `quantidade` int(20) NOT NULL,
  `estado` varchar(25) NOT NULL,
  `data_atual` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_presenca`
--

CREATE TABLE `tb_presenca` (
  `id_presenca` int(100) NOT NULL,
  `id_membro` int(100) NOT NULL,
  `id_actividade` int(100) NOT NULL,
  `estado` varchar(20) NOT NULL,
  `data_presenca` date NOT NULL,
  `data_atual` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_saida`
--

CREATE TABLE `tb_saida` (
  `id_saida` int(100) NOT NULL,
  `id_membro` int(100) NOT NULL,
  `id_total` int(100) NOT NULL,
  `descricao` varchar(100) CHARACTER SET utf8 NOT NULL,
  `valor` double NOT NULL,
  `data_saida` datetime(6) NOT NULL,
  `data_atual` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_total`
--

CREATE TABLE `tb_total` (
  `id_total` int(100) NOT NULL,
  `total_entrada` double NOT NULL,
  `total_saida` double NOT NULL,
  `total` double NOT NULL,
  `data_atual` datetime NOT NULL DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_usuario`
--

CREATE TABLE `tb_usuario` (
  `id_user` int(11) NOT NULL,
  `user` varchar(100) NOT NULL,
  `senha` varchar(200) NOT NULL,
  `cargo` varchar(50) NOT NULL,
  `data_atual` datetime NOT NULL DEFAULT current_timestamp(),
  `status` int(10) NOT NULL DEFAULT 1
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_usuario`
--

INSERT INTO `tb_usuario` (`id_user`, `user`, `senha`, `cargo`, `data_atual`, `status`) VALUES
(1, 'jimub', 'jimub2021', 'Admin', '2018-12-17 18:13:25', 1);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `tb_actividade`
--
ALTER TABLE `tb_actividade`
  ADD PRIMARY KEY (`id_actividade`);

--
-- Índices para tabela `tb_cargo`
--
ALTER TABLE `tb_cargo`
  ADD PRIMARY KEY (`id_cargo`);

--
-- Índices para tabela `tb_categoria`
--
ALTER TABLE `tb_categoria`
  ADD PRIMARY KEY (`id_categoria`);

--
-- Índices para tabela `tb_comissao`
--
ALTER TABLE `tb_comissao`
  ADD PRIMARY KEY (`id_comissao`);

--
-- Índices para tabela `tb_cota`
--
ALTER TABLE `tb_cota`
  ADD PRIMARY KEY (`id_cota`);

--
-- Índices para tabela `tb_emprestimo`
--
ALTER TABLE `tb_emprestimo`
  ADD PRIMARY KEY (`id_emprestimo`);

--
-- Índices para tabela `tb_entrada`
--
ALTER TABLE `tb_entrada`
  ADD PRIMARY KEY (`id_entrada`);

--
-- Índices para tabela `tb_filiacao`
--
ALTER TABLE `tb_filiacao`
  ADD PRIMARY KEY (`id_filiacao`);

--
-- Índices para tabela `tb_fornecedor`
--
ALTER TABLE `tb_fornecedor`
  ADD PRIMARY KEY (`id_fornecedor`);

--
-- Índices para tabela `tb_grupo`
--
ALTER TABLE `tb_grupo`
  ADD PRIMARY KEY (`id_grupo`);

--
-- Índices para tabela `tb_livros`
--
ALTER TABLE `tb_livros`
  ADD PRIMARY KEY (`id_livro`);

--
-- Índices para tabela `tb_log`
--
ALTER TABLE `tb_log`
  ADD PRIMARY KEY (`id_log`);

--
-- Índices para tabela `tb_membros`
--
ALTER TABLE `tb_membros`
  ADD PRIMARY KEY (`id_membro`);

--
-- Índices para tabela `tb_mensagem`
--
ALTER TABLE `tb_mensagem`
  ADD PRIMARY KEY (`id_mensagem`);

--
-- Índices para tabela `tb_mes`
--
ALTER TABLE `tb_mes`
  ADD PRIMARY KEY (`id_mes`);

--
-- Índices para tabela `tb_morada`
--
ALTER TABLE `tb_morada`
  ADD PRIMARY KEY (`id_morada`);

--
-- Índices para tabela `tb_patrimonio`
--
ALTER TABLE `tb_patrimonio`
  ADD PRIMARY KEY (`id_patrimonio`);

--
-- Índices para tabela `tb_presenca`
--
ALTER TABLE `tb_presenca`
  ADD PRIMARY KEY (`id_presenca`);

--
-- Índices para tabela `tb_saida`
--
ALTER TABLE `tb_saida`
  ADD PRIMARY KEY (`id_saida`);

--
-- Índices para tabela `tb_total`
--
ALTER TABLE `tb_total`
  ADD PRIMARY KEY (`id_total`);

--
-- Índices para tabela `tb_usuario`
--
ALTER TABLE `tb_usuario`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tb_actividade`
--
ALTER TABLE `tb_actividade`
  MODIFY `id_actividade` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=42;

--
-- AUTO_INCREMENT de tabela `tb_cargo`
--
ALTER TABLE `tb_cargo`
  MODIFY `id_cargo` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT de tabela `tb_categoria`
--
ALTER TABLE `tb_categoria`
  MODIFY `id_categoria` int(100) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tb_comissao`
--
ALTER TABLE `tb_comissao`
  MODIFY `id_comissao` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT de tabela `tb_cota`
--
ALTER TABLE `tb_cota`
  MODIFY `id_cota` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=53;

--
-- AUTO_INCREMENT de tabela `tb_emprestimo`
--
ALTER TABLE `tb_emprestimo`
  MODIFY `id_emprestimo` int(100) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tb_entrada`
--
ALTER TABLE `tb_entrada`
  MODIFY `id_entrada` int(100) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tb_filiacao`
--
ALTER TABLE `tb_filiacao`
  MODIFY `id_filiacao` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=143;

--
-- AUTO_INCREMENT de tabela `tb_fornecedor`
--
ALTER TABLE `tb_fornecedor`
  MODIFY `id_fornecedor` int(100) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tb_grupo`
--
ALTER TABLE `tb_grupo`
  MODIFY `id_grupo` int(100) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tb_livros`
--
ALTER TABLE `tb_livros`
  MODIFY `id_livro` int(100) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tb_log`
--
ALTER TABLE `tb_log`
  MODIFY `id_log` int(6) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=83;

--
-- AUTO_INCREMENT de tabela `tb_membros`
--
ALTER TABLE `tb_membros`
  MODIFY `id_membro` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=132;

--
-- AUTO_INCREMENT de tabela `tb_mensagem`
--
ALTER TABLE `tb_mensagem`
  MODIFY `id_mensagem` int(100) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tb_mes`
--
ALTER TABLE `tb_mes`
  MODIFY `id_mes` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=79;

--
-- AUTO_INCREMENT de tabela `tb_morada`
--
ALTER TABLE `tb_morada`
  MODIFY `id_morada` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=158;

--
-- AUTO_INCREMENT de tabela `tb_patrimonio`
--
ALTER TABLE `tb_patrimonio`
  MODIFY `id_patrimonio` int(100) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tb_presenca`
--
ALTER TABLE `tb_presenca`
  MODIFY `id_presenca` int(100) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tb_saida`
--
ALTER TABLE `tb_saida`
  MODIFY `id_saida` int(100) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tb_total`
--
ALTER TABLE `tb_total`
  MODIFY `id_total` int(100) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT de tabela `tb_usuario`
--
ALTER TABLE `tb_usuario`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
