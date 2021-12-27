-- phpMyAdmin SQL Dump
-- version 4.2.11
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 24-Jul-2020 às 00:02
-- Versão do servidor: 5.6.21
-- PHP Version: 5.6.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `jimub`
--

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_actividade`
--

CREATE TABLE IF NOT EXISTS `tb_actividade` (
`id_actividade` int(100) NOT NULL,
  `id_comissaoR` int(100) NOT NULL,
  `tema` varchar(200) CHARACTER SET utf8 NOT NULL,
  `objectivo` varchar(200) CHARACTER SET utf8 NOT NULL,
  `orador` varchar(100) CHARACTER SET utf8 NOT NULL,
  `estado` varchar(100) NOT NULL,
  `local` varchar(50) NOT NULL,
  `data_actividade` date NOT NULL,
  `hora_actividade` varchar(5) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=42 DEFAULT CHARSET=latin1;

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

CREATE TABLE IF NOT EXISTS `tb_cargo` (
`id_cargo` int(100) NOT NULL,
  `cargo` varchar(150) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=35 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_cargo`
--

INSERT INTO `tb_cargo` (`id_cargo`, `cargo`) VALUES
(9, 'Secretário Executivo'),
(10, 'Secretário de Evangelismo'),
(18, 'Base'),
(19, 'Director'),
(20, 'Vice-Director'),
(21, 'Tesoureiro'),
(22, 'Vice Secretario de Evangelismo'),
(23, 'Secretário de Comunicação e informação'),
(24, 'Vice Secretario de Comunicação e informação'),
(25, 'Secretário de Fraternidade e ecumenismo'),
(26, 'Vice Secretario de Fraternidade e ecumenismo'),
(27, 'Secretário de Recreio e desporto'),
(28, 'Vice Secretario de Recreio e desporto '),
(29, 'Secretário de Serviços Sociais e comunitarios\r\n'),
(30, 'Vice Secretario de Serviços Sociais e comunitarios'),
(31, 'Coordenador Dos Adolescentes\r\n'),
(32, 'Vice Coordenador Dos Adolescentes'),
(33, 'Secretário de Cultura\r\n'),
(34, 'Vice Secretario de Cultura');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_categoria`
--

CREATE TABLE IF NOT EXISTS `tb_categoria` (
`id_categoria` int(100) NOT NULL,
  `descricao` varchar(250) CHARACTER SET utf8 NOT NULL,
  `data_atual` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_comissao`
--

CREATE TABLE IF NOT EXISTS `tb_comissao` (
`id_comissao` int(100) NOT NULL,
  `comissao` varchar(100) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=16 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_comissao`
--

INSERT INTO `tb_comissao` (`id_comissao`, `comissao`) VALUES
(8, 'Nenhuma'),
(9, 'Comunicação e Informação'),
(10, 'Evangelismo'),
(12, 'Fraternidade e ecumenismo\r\n'),
(13, 'Recreio e desporto'),
(14, 'Serviços Sociais e comunitarios\r\n'),
(15, 'Cultura');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_cota`
--

CREATE TABLE IF NOT EXISTS `tb_cota` (
`id_cota` int(100) NOT NULL,
  `id_membro` int(100) NOT NULL,
  `id_mes` int(100) NOT NULL,
  `total_apagar` double NOT NULL,
  `total_pago` double NOT NULL,
  `troco` double NOT NULL,
  `total` int(100) NOT NULL,
  `data_pagamento` datetime(6) NOT NULL,
  `estadop` varchar(100) NOT NULL,
  `data_atualC` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=latin1;

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

CREATE TABLE IF NOT EXISTS `tb_emprestimo` (
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
  `data_atual` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_entrada`
--

CREATE TABLE IF NOT EXISTS `tb_entrada` (
`id_entrada` int(100) NOT NULL,
  `id_membro` int(100) NOT NULL,
  `id_total` int(100) NOT NULL,
  `descricao` varchar(100) CHARACTER SET utf8 NOT NULL,
  `valor` double NOT NULL,
  `data_entrada` datetime(6) NOT NULL,
  `data_atual` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_filiacao`
--

CREATE TABLE IF NOT EXISTS `tb_filiacao` (
`id_filiacao` int(10) NOT NULL,
  `pai` varchar(50) NOT NULL,
  `mae` varchar(50) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_filiacao`
--

INSERT INTO `tb_filiacao` (`id_filiacao`, `pai`, `mae`) VALUES
(1, 'Father', 'Mother'),
(2, 'Dad', 'Mam'),
(3, 'Pai', 'Mãe'),
(4, 'papi', 'Mami'),
(5, 'Bethel', 'Bethel'),
(6, 'Pai', 'Mãe');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_fornecedor`
--

CREATE TABLE IF NOT EXISTS `tb_fornecedor` (
`id_fornecedor` int(100) NOT NULL,
  `nome` varchar(150) CHARACTER SET utf8 NOT NULL,
  `telefone1` int(30) NOT NULL,
  `telefone2` int(30) NOT NULL,
  `data_atual` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_grupo`
--

CREATE TABLE IF NOT EXISTS `tb_grupo` (
`id_grupo` int(100) NOT NULL,
  `grupo` varchar(100) NOT NULL,
  `dirigente1` varchar(100) NOT NULL,
  `dirigente2` varchar(100) NOT NULL,
  `coordenador` varchar(100) NOT NULL,
  `vice-coordenador` varchar(100) NOT NULL,
  `estado` varchar(50) NOT NULL,
  `data_atual` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_livros`
--

CREATE TABLE IF NOT EXISTS `tb_livros` (
`id_livro` int(100) NOT NULL,
  `id_forncedor` int(100) NOT NULL,
  `id_categoria` int(100) NOT NULL,
  `titulo` varchar(150) CHARACTER SET utf8 NOT NULL,
  `descricao` varchar(250) CHARACTER SET utf8 NOT NULL,
  `autor` varchar(100) CHARACTER SET utf8 NOT NULL,
  `imagem` varchar(200) NOT NULL,
  `quantidade` int(20) NOT NULL,
  `valor_emprestimo` double NOT NULL,
  `data_atual` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_membros`
--

CREATE TABLE IF NOT EXISTS `tb_membros` (
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
  `profissao` varchar(80) NOT NULL,
  `id_cargo` int(100) NOT NULL,
  `id_comissao` int(100) NOT NULL,
  `grupo` varchar(100) NOT NULL,
  `data_nascimento` date NOT NULL,
  `cat_membro` varchar(100) NOT NULL,
  `classe` varchar(150) NOT NULL,
  `imagem` varchar(200) NOT NULL,
  `data_emissao` date NOT NULL,
  `igreja_Anterior` varchar(100) NOT NULL,
  `funcaoA_Exercer` varchar(100) NOT NULL,
  `descricao_Organizacao` varchar(100) NOT NULL,
  `estado` varchar(100) NOT NULL,
  `data_atual` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_membros`
--

INSERT INTO `tb_membros` (`id_membro`, `nome`, `alcunha`, `telefone1`, `telefone2`, `idade`, `sexo`, `id_morada`, `estado_civil`, `BI_Cedula`, `id_filiacao`, `email`, `facebook`, `areaFormacao`, `nivelEscolar`, `escola`, `profissao`, `id_cargo`, `id_comissao`, `grupo`, `data_nascimento`, `cat_membro`, `classe`, `imagem`, `data_emissao`, `igreja_Anterior`, `funcaoA_Exercer`, `descricao_Organizacao`, `estado`, `data_atual`) VALUES
(8, 'Joel Anselmo', 'Joel', 946544245, 995334334, 22, 'Masculino', 9, 'Solteiro', '21345434LA345', 1, '', 'Joel anselmo', 'Eng.Mecânica', '12º', 'Macarenco', 'Eng.Mecânico', 9, 9, 'Coral Dos Adolescentes', '1997-10-20', 'Efectivo', 'Corintios', 'InShot_20181018_164305418.jpg', '2014-06-11', '', 'Guia', 'Jovens Precisam de conhecer demonios', 'Vivo', '2018-12-26 02:15:04'),
(9, 'Eduardo Cristiano Da Silva Kiassucumuca', 'Marcio', 930340539, 998990545, 20, 'Masculino', 10, 'Solteiro', '01923495LA123', 2, '', 'Marcio kiassucumuca', 'Eng.Informática', '4ºano', 'Isptec', 'Desenvolvedor Web', 10, 10, 'Coral Dos Adolescentes', '1999-07-14', 'Aprova', 'Sebastião Gaspar', '', '2014-07-23', '', 'Ensinador das escrituras', 'Fraterna e pouco espiritual.', 'Vivo', '2018-12-26 02:23:52'),
(12, 'jimub', 'jimub', 920090433, 993423344, 14, 'Masculino', 18, 'Solteiro', '0123456LA123', 5, 'jimub@hotmail.com', 'jimub unida', 'jimub adorador', '2', 'Bethel', 'jimub gospel', 18, 8, 'Nenhum', '2006-11-30', 'Efectivo', 'Sebastião Gaspar', '', '2020-02-02', 'Igreja Anterior', 'Pastor', 'Fraterna e pouco espiritual.', 'Vivo', '2020-01-16 23:06:09');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_mensagem`
--

CREATE TABLE IF NOT EXISTS `tb_mensagem` (
`id_mensagem` int(100) NOT NULL,
  `id_membro` int(100) NOT NULL,
  `id_actividade` int(100) NOT NULL,
  `descricao` varchar(200) CHARACTER SET utf8 NOT NULL,
  `data_atual` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_mes`
--

CREATE TABLE IF NOT EXISTS `tb_mes` (
`id_mes` int(100) NOT NULL,
  `id_membro` int(100) NOT NULL,
  `mes` varchar(100) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=79 DEFAULT CHARSET=latin1;

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

CREATE TABLE IF NOT EXISTS `tb_morada` (
`id_morada` int(100) NOT NULL,
  `bairro` varchar(100) NOT NULL,
  `rua` varchar(100) NOT NULL,
  `descricao_casa` varchar(100) NOT NULL
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_morada`
--

INSERT INTO `tb_morada` (`id_morada`, `bairro`, `rua`, `descricao_casa`) VALUES
(2, 'Avenida Combandante valódia', 'Combatentes', '10'),
(3, 'Valódia', 'Combatentes', '10'),
(4, 'Valodi', 'Combatentes', '10'),
(5, 'df', 'df', 'df'),
(6, 'Bairroer', 'Ruaer', 'Descrdfição ou numero da casa'),
(7, 'Bairrosds', 'Ruasdsd', 'Descriçãsdso ou numero da casa'),
(8, 'Lisboa', 'Setubal', '10'),
(9, 'Rangel', 'Lama', 'Junto ao Milenium'),
(10, 'Valódia', 'Combatentes', '10'),
(11, 'V', 'Combatentes', '10'),
(12, 'Bairro', 'Rua', 'Descrição ou numero da casa'),
(13, 'jimub', 'jimub', 'JACO'),
(14, 'Bairro', 'Rua', 'Descrição ou numero da casa'),
(15, 'Bairro', 'Rua', 'Descrição ou numero da casa'),
(16, 'Bairro', 'Rua', 'Descrição ou numero da casa'),
(17, 'Bairro', 'Rua', 'Descrição ou numero da casa'),
(18, 'Marçal', 'Cidadela', '33'),
(19, 'Bairro', 'Rua', 'Descrição ou numero da casa');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_patrimonio`
--

CREATE TABLE IF NOT EXISTS `tb_patrimonio` (
`id_patrimonio` int(100) NOT NULL,
  `id_comissao` int(100) NOT NULL,
  `descricao` varchar(200) CHARACTER SET utf8 NOT NULL,
  `quantidade` int(20) NOT NULL,
  `estado` varchar(25) NOT NULL,
  `data_atual` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_presenca`
--

CREATE TABLE IF NOT EXISTS `tb_presenca` (
`id_presenca` int(100) NOT NULL,
  `id_membro` int(100) NOT NULL,
  `id_actividade` int(100) NOT NULL,
  `estado` varchar(20) NOT NULL,
  `data_presenca` date NOT NULL,
  `data_atual` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_saida`
--

CREATE TABLE IF NOT EXISTS `tb_saida` (
`id_saida` int(100) NOT NULL,
  `id_membro` int(100) NOT NULL,
  `id_total` int(100) NOT NULL,
  `descricao` varchar(100) CHARACTER SET utf8 NOT NULL,
  `valor` double NOT NULL,
  `data_saida` datetime(6) NOT NULL,
  `data_atual` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_total`
--

CREATE TABLE IF NOT EXISTS `tb_total` (
`id_total` int(100) NOT NULL,
  `total_entrada` double NOT NULL,
  `total_saida` double NOT NULL,
  `total` double NOT NULL,
  `data_atual` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_usuario`
--

CREATE TABLE IF NOT EXISTS `tb_usuario` (
`id_user` int(11) NOT NULL,
  `user` varchar(100) NOT NULL,
  `senha` varchar(200) NOT NULL,
  `cargo` varchar(50) NOT NULL,
  `data_atual` datetime NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tb_usuario`
--

INSERT INTO `tb_usuario` (`id_user`, `user`, `senha`, `cargo`, `data_atual`) VALUES
(1, 'Cristiano', 'edkiassu', 'Admin', '2018-12-17 18:13:25'),
(2, 'Mingo', 'mingobile', 'Secretário(a)', '2020-07-12 18:47:26'),
(3, 'Usuário', 'Senha', 'Cargo', '2020-07-13 17:20:49'),
(4, 'Muka', 'laravel2', 'Secretário(a)', '2020-07-13 19:13:06'),
(5, 'qw', 'aa', 'Diretor(a)', '2020-07-14 14:43:33'),
(6, 'Usuáriosd', 'Senhasd', 'Diretor(a)', '2020-07-14 17:53:26');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tb_actividade`
--
ALTER TABLE `tb_actividade`
 ADD PRIMARY KEY (`id_actividade`);

--
-- Indexes for table `tb_cargo`
--
ALTER TABLE `tb_cargo`
 ADD PRIMARY KEY (`id_cargo`);

--
-- Indexes for table `tb_categoria`
--
ALTER TABLE `tb_categoria`
 ADD PRIMARY KEY (`id_categoria`);

--
-- Indexes for table `tb_comissao`
--
ALTER TABLE `tb_comissao`
 ADD PRIMARY KEY (`id_comissao`);

--
-- Indexes for table `tb_cota`
--
ALTER TABLE `tb_cota`
 ADD PRIMARY KEY (`id_cota`);

--
-- Indexes for table `tb_emprestimo`
--
ALTER TABLE `tb_emprestimo`
 ADD PRIMARY KEY (`id_emprestimo`);

--
-- Indexes for table `tb_entrada`
--
ALTER TABLE `tb_entrada`
 ADD PRIMARY KEY (`id_entrada`);

--
-- Indexes for table `tb_filiacao`
--
ALTER TABLE `tb_filiacao`
 ADD PRIMARY KEY (`id_filiacao`);

--
-- Indexes for table `tb_fornecedor`
--
ALTER TABLE `tb_fornecedor`
 ADD PRIMARY KEY (`id_fornecedor`);

--
-- Indexes for table `tb_grupo`
--
ALTER TABLE `tb_grupo`
 ADD PRIMARY KEY (`id_grupo`);

--
-- Indexes for table `tb_livros`
--
ALTER TABLE `tb_livros`
 ADD PRIMARY KEY (`id_livro`);

--
-- Indexes for table `tb_membros`
--
ALTER TABLE `tb_membros`
 ADD PRIMARY KEY (`id_membro`);

--
-- Indexes for table `tb_mensagem`
--
ALTER TABLE `tb_mensagem`
 ADD PRIMARY KEY (`id_mensagem`);

--
-- Indexes for table `tb_mes`
--
ALTER TABLE `tb_mes`
 ADD PRIMARY KEY (`id_mes`);

--
-- Indexes for table `tb_morada`
--
ALTER TABLE `tb_morada`
 ADD PRIMARY KEY (`id_morada`);

--
-- Indexes for table `tb_patrimonio`
--
ALTER TABLE `tb_patrimonio`
 ADD PRIMARY KEY (`id_patrimonio`);

--
-- Indexes for table `tb_presenca`
--
ALTER TABLE `tb_presenca`
 ADD PRIMARY KEY (`id_presenca`);

--
-- Indexes for table `tb_saida`
--
ALTER TABLE `tb_saida`
 ADD PRIMARY KEY (`id_saida`);

--
-- Indexes for table `tb_total`
--
ALTER TABLE `tb_total`
 ADD PRIMARY KEY (`id_total`);

--
-- Indexes for table `tb_usuario`
--
ALTER TABLE `tb_usuario`
 ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tb_actividade`
--
ALTER TABLE `tb_actividade`
MODIFY `id_actividade` int(100) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=42;
--
-- AUTO_INCREMENT for table `tb_cargo`
--
ALTER TABLE `tb_cargo`
MODIFY `id_cargo` int(100) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=35;
--
-- AUTO_INCREMENT for table `tb_categoria`
--
ALTER TABLE `tb_categoria`
MODIFY `id_categoria` int(100) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_comissao`
--
ALTER TABLE `tb_comissao`
MODIFY `id_comissao` int(100) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=16;
--
-- AUTO_INCREMENT for table `tb_cota`
--
ALTER TABLE `tb_cota`
MODIFY `id_cota` int(100) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=53;
--
-- AUTO_INCREMENT for table `tb_emprestimo`
--
ALTER TABLE `tb_emprestimo`
MODIFY `id_emprestimo` int(100) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_entrada`
--
ALTER TABLE `tb_entrada`
MODIFY `id_entrada` int(100) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_filiacao`
--
ALTER TABLE `tb_filiacao`
MODIFY `id_filiacao` int(10) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT for table `tb_fornecedor`
--
ALTER TABLE `tb_fornecedor`
MODIFY `id_fornecedor` int(100) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_grupo`
--
ALTER TABLE `tb_grupo`
MODIFY `id_grupo` int(100) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_livros`
--
ALTER TABLE `tb_livros`
MODIFY `id_livro` int(100) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_membros`
--
ALTER TABLE `tb_membros`
MODIFY `id_membro` int(100) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=13;
--
-- AUTO_INCREMENT for table `tb_mensagem`
--
ALTER TABLE `tb_mensagem`
MODIFY `id_mensagem` int(100) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_mes`
--
ALTER TABLE `tb_mes`
MODIFY `id_mes` int(100) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=79;
--
-- AUTO_INCREMENT for table `tb_morada`
--
ALTER TABLE `tb_morada`
MODIFY `id_morada` int(100) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=20;
--
-- AUTO_INCREMENT for table `tb_patrimonio`
--
ALTER TABLE `tb_patrimonio`
MODIFY `id_patrimonio` int(100) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_presenca`
--
ALTER TABLE `tb_presenca`
MODIFY `id_presenca` int(100) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_saida`
--
ALTER TABLE `tb_saida`
MODIFY `id_saida` int(100) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_total`
--
ALTER TABLE `tb_total`
MODIFY `id_total` int(100) NOT NULL AUTO_INCREMENT;
--
-- AUTO_INCREMENT for table `tb_usuario`
--
ALTER TABLE `tb_usuario`
MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT,AUTO_INCREMENT=8;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
