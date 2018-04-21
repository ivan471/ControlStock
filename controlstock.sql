-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 21 Apr 2018 pada 13.41
-- Versi Server: 10.1.28-MariaDB
-- PHP Version: 7.1.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `controlstock`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `kondisi_stock`
--

CREATE TABLE `kondisi_stock` (
  `Kode_Barang` char(8) NOT NULL,
  `Jumlah_barang` int(11) NOT NULL,
  `keterangan` varchar(255) NOT NULL,
  `Tanggal` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `kondisi_stock`
--

INSERT INTO `kondisi_stock` (`Kode_Barang`, `Jumlah_barang`, `keterangan`, `Tanggal`) VALUES
('00000001', 15, 'rusak', '2018-04-25'),
('00000001', 5, 'Bocor', '2018-05-01');

-- --------------------------------------------------------

--
-- Struktur dari tabel `stock`
--

CREATE TABLE `stock` (
  `Kode_Barang` char(8) NOT NULL,
  `Nama` varchar(40) NOT NULL,
  `Merek` varchar(20) NOT NULL,
  `Jumlah` int(11) NOT NULL,
  `Min_stock` int(11) NOT NULL,
  `Max_stock` int(11) NOT NULL,
  `Satuan` varchar(10) NOT NULL,
  `Status` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `stock`
--

INSERT INTO `stock` (`Kode_Barang`, `Nama`, `Merek`, `Jumlah`, `Min_stock`, `Max_stock`, `Satuan`, `Status`) VALUES
('00000001', 'Cat', 'Avian', 14, 18, 40, 'Kaleng', 'Stock Minimum'),
('00000002', 'Semen', 'Tonasa', 25, 15, 50, 'Sack', 'Cukup'),
('00000003', 'Seng', 'Sakuraroof', 62, 10, 25, 'Lembar', 'Stock Maksimum'),
('00000004', 'Paku 5 Cm', '', 24, 10, 35, 'Pcs', 'Cukup'),
('00000005', 'Pipa ', 'Wavin', 25, 15, 60, 'Biji', 'Cukup');

-- --------------------------------------------------------

--
-- Struktur dari tabel `stock_keluar`
--

CREATE TABLE `stock_keluar` (
  `Kode_barang` char(8) NOT NULL,
  `Jumlah_keluar` int(11) NOT NULL,
  `Tanggal_keluar` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `stock_keluar`
--

INSERT INTO `stock_keluar` (`Kode_barang`, `Jumlah_keluar`, `Tanggal_keluar`) VALUES
('00000001', 20, '2018-05-03'),
('00000005', 15, '2018-05-01');

-- --------------------------------------------------------

--
-- Struktur dari tabel `stock_masuk`
--

CREATE TABLE `stock_masuk` (
  `Kode_Barang` char(8) NOT NULL,
  `Jumlah_masuk` int(11) NOT NULL,
  `Tanggal` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `stock_masuk`
--

INSERT INTO `stock_masuk` (`Kode_Barang`, `Jumlah_masuk`, `Tanggal`) VALUES
('00000001', 5, '2018-04-10'),
('00000005', 10, '2018-04-30');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `stock`
--
ALTER TABLE `stock`
  ADD PRIMARY KEY (`Kode_Barang`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
