-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 13, 2024 at 12:44 PM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.4.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `sewaspd`
--

-- --------------------------------------------------------

--
-- Table structure for table `pelanggan`
--

CREATE TABLE `pelanggan` (
  `username` varchar(155) NOT NULL,
  `password` varchar(16) NOT NULL,
  `nama_pelanggan` varchar(255) NOT NULL,
  `nomor_telepon` varchar(13) NOT NULL,
  `alamat` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `pelanggan`
--

INSERT INTO `pelanggan` (`username`, `password`, `nama_pelanggan`, `nomor_telepon`, `alamat`) VALUES
('UjangM', '1234', 'Ujang Mahendra', '0812345678', 'Jalan. Rumah Saya No.1 Blok Z');

-- --------------------------------------------------------

--
-- Table structure for table `sepeda_listrik`
--

CREATE TABLE `sepeda_listrik` (
  `kode_sepeda` varchar(10) NOT NULL,
  `tipe_sepeda` varchar(155) NOT NULL,
  `kapasitas_baterai` int(11) NOT NULL,
  `jarak_tempuh` int(11) NOT NULL,
  `tarif` int(255) NOT NULL,
  `status` enum('tersedia','disewa','diperbaiki','') NOT NULL,
  `perawatan_terakhir` date NOT NULL,
  `id_stasiun` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `sepeda_listrik`
--

INSERT INTO `sepeda_listrik` (`kode_sepeda`, `tipe_sepeda`, `kapasitas_baterai`, `jarak_tempuh`, `tarif`, `status`, `perawatan_terakhir`, `id_stasiun`) VALUES
('CVX001', 'Crosser VX', 12, 60, 80000, 'tersedia', '2024-05-13', 'SMD101 - S'),
('VP003', 'Varilux Pro', 960, 65, 65000, 'tersedia', '2024-05-13', 'SMD101 - S'),
('VR5002', 'Ventura R5', 12, 50, 50000, 'tersedia', '2024-05-10', 'BPN101 - J');

-- --------------------------------------------------------

--
-- Table structure for table `transaksi`
--

CREATE TABLE `transaksi` (
  `id_transaksi` varchar(5) NOT NULL,
  `id_pelanggan` int(5) NOT NULL,
  `id_sepeda` varchar(10) NOT NULL,
  `tgl_sewa_awal` date NOT NULL,
  `tgl_sewa_akhir` date NOT NULL,
  `paket` varchar(255) NOT NULL,
  `status` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `sepeda_listrik`
--
ALTER TABLE `sepeda_listrik`
  ADD PRIMARY KEY (`kode_sepeda`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
