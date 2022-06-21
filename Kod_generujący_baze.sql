--Skrypt Generuj¹cy baze danych

USE master; 

GO 

IF DB_ID (N'PROJEKT') IS NOT NULL 

DROP DATABASE PROJEKT;  

  

CREATE DATABASE PROJEKT 

COLLATE Polish_100_CI_AS;  

 USE PROJEKT; 
 
--------------------------------------------------------
--------------------------------------------------------

CREATE TABLE [dbo]. [Kategoria]( 

[ID] [int] PRIMARY KEY IDENTITY, 

[Nazwa] [nvarchar] (250) NOT NULL  CHECK ([Nazwa] IN 

('BaarterItems', 'Gear', 'WeaponsParts', 'Weapons', 'Ammo', 'Provisions', 'Medication', 'Keys', 'SpecialEquipment', 

'Maps', 'Money'))) 

  

CREATE TABLE [dbo]. [Itemy]( 

[ID] [int] PRIMARY KEY IDENTITY, 

[Nazwa] [nvarchar] (250) NOT NULL, 

[KategoriaID] [int] FOREIGN KEY REFERENCES Kategoria(ID) 

) 

-------------------------------------------------------- 

--Traderzy-- 

-------------------------------------------------------- 

CREATE TABLE [dbo]. [Prapor]( 

[ItemID] [int] FOREIGN KEY REFERENCES Itemy(ID), 

[CenaSprzeda¿y] [int], 

[CenaKupna] [int], 

[Level] [int] CHECK ([Level] IN (1,2,3,4) ) DEFAULT 1) 


CREATE TABLE [dbo]. [Therapist]( 

[ItemID] [int] FOREIGN KEY REFERENCES Itemy(ID), 

[CenaSprzeda¿y] [int], 

[CenaKupna] [int], 

[Level] [int] CHECK ([Level] IN (1,2,3,4) ) DEFAULT 1) 


CREATE TABLE [dbo]. [Skier]( 

[ItemID] [int] FOREIGN KEY REFERENCES Itemy(ID), 

[CenaSprzeda¿y] [int], 

[CenaKupna] [int], 

[Level] [int] CHECK ([Level] IN (1,2,3,4) ) DEFAULT 1) 


CREATE TABLE [dbo]. [Ragman]( 

[ItemID] [int] FOREIGN KEY REFERENCES Itemy(ID), 

[CenaSprzeda¿y] [int], 

[CenaKupna] [int], 

[Level] [int] CHECK ([Level] IN (1,2,3,4) ) DEFAULT 1) 


CREATE TABLE [dbo]. [Mechanic]( 

[ItemID] [int] FOREIGN KEY REFERENCES Itemy(ID), 

[CenaSprzeda¿y] [int], 

[CenaKupna] [int], 

[Level] [int] CHECK ([Level] IN (1,2,3,4) ) DEFAULT 1) 


CREATE TABLE [dbo]. [Jaeger]( 

[ItemID] [int] FOREIGN KEY REFERENCES Itemy(ID), 

[CenaSprzeda¿y] [int], 

[CenaKupna] [int], 

[Level] [int] CHECK ([Level] IN (1,2,3,4) ) DEFAULT 1) 

  

--Peacekepper jako jedyny sprzedaje / kupuje w dolarach zamiast w rublach  
--Cena dolara zmienia siê dynamicznie, przyjêto 1$ = 112 rubli

CREATE TABLE [dbo]. [Peacekeeper]( 

[ItemID] [int] FOREIGN KEY REFERENCES Itemy(ID), 

[CenaSprzeda¿y] [int], 

[CenaKupna] [int], 

[Level] [int] CHECK ([Level] IN (1,2,3,4) ) DEFAULT 1) 

-------------------------------------------------------- 
-------------------------------------------------------- 

INSERT INTO Kategoria (Nazwa)
VALUES
('BaarterItems'), ('Gear'), ('WeaponsParts'), ('Weapons'), ('Ammo'), ('Provisions'), ('Medication'), ('Keys'),
('SpecialEquipment'), ('Maps'), ('Money')


-------------------------------------------------------- 
--Itemy
-------------------------------------------------------- 

INSERT INTO Itemy (Nazwa, KategoriaID)
VALUES

--Barter items

--Flammable materials
('Metal fuel tank', '1'),
--Gear
-- Backpacks
('WARTECH Berkut BB-102 backpack', '2'),
('Flyye MBSS backpack', '2'),
('Scav backpack', '2'),
('LBT-8005A Day Pack backpack', '2'),
--Body armor
('6B2 body armor (Flora)', '2'),
('6B23-1 body armor (Digitam Flora', '2'),
('PACA Soft Armor', '2'),
--Headgear
('6B47 "Patnik-BSh" helmet', '2'),
('SSh-68 steel helmet', '2'),
('UNTAR helmet', '2'),
--Headsets
('Peltor ComTac 2 headset', '2'),
('Peltor Tactical Sport headset', '2'),
--Storage containers
('Lucky Scav Junk box', '2'),
--Tactical rigs
('CSA chest rig', '2'),
('Spiritus Systems Bank Robber chest rig', '2'),
('UMTBS 6sh112 Scout-Sniper', '2'),
('Umka M33-SET1 hunter vest', '2'),
('WARTECH MK3 TV-104 ches rig', '2'),

--Weapon parts & mods

--Auxiliary parts
('Axion KObra sight shade', '3'),
--Foregrips
('KAC vertical foregirp', '3'),
('Viking Tactics UVG tactical foregrip', '3'),
('Zenit RK-6 tactical foregrip', '3'),
--Light & laser devices
--laser target pointers
('NcSTAR Tactical blue laser LAM-module', '3'),
--Tactical combo debices
('Glock GTL 21 tactical flashlight with laser', '3'),
('SureFire XC1 tactical flashlight', '3'),
--Muzzle devices
--Flashhiders & brakes
('PWS CQB 5.56x45 muzzle brake', '3'),
--Muzzle adapters
('ME Cylinder 12ga muzzle adapter', '3'),
--Suppressors
('Rotor 43 .366 TKM muzzle brake-compensator', '3'),
('AKM Hexagon 7.62x39 sound suppressor', '3'),
--Sights
--Assault scopes
('Trijicon ACOG TA01NSN 4x32 scope (Black)', '3'),
--Colimators
('Axion Kobra EKP-8-02 reflex sight (dobetail', '3'),
('Walther MRS reflex sight', '3'),
--Compact collimators
('BelOMO PK-06 reflex sight', '3'),
--Optics
('BelOMO PSO-1 4x24 scope', '3'),
('VOMZ Pilad 4x32 riflescope', '3'),
--Special purpose sights
('Torrey Pines Logic T12W thermal reflex sight', '3'),
--Gear mods
--Charging handles
('AK Zenit RP-1 charging handle', '3'), 
('5.56x45 Colt AR-15 STANG 30-round magazine', '3'),
('AK-74 5.45x39 6L23 30-round magazine', '3'),
('AK-74 5.45x39 6L31 60-round magazine', '3'),
--Stocks & chassis
('AK Zenit PT-1 "Klassika" stock', '3'), 
('Magpul MOE Carbine stock (FDE)', '3'),
--Barrels
('AR-15 5.56x45 Molot Arms 406mm barrel', '3'), 
--Gas blocks
('Daniel Degense MK12 Low Profile Gas Block', '3'),
--Handguards
('AK Magpul MOE AKM handguard (Black)', '3'),
('AKS-74 Zenit B-11 handguard', '3'),
('AR-15 KAC RIS handguard', '3'),
('AR-15 DLG Tactical DLG-123 pistol grip', '3'),

--Weapons

--Asault carvines
('ADAR 2-15 5.56x45 carbine', '4'),
('Molot VPO-209 .366 TKM carbine', '4'),
('Simonov SKS 7.62x39 carbine', '4'),
--Asault rifles
('Colt M4A1 5.56x45 assault rifle Standard', '4'),
('Desert Tech MDR 5.56x45 assault rifle', '4'),
('FN SCAR-H 7.62x51 assault rifle (FDE)', '4'), 
('Kalashnikov AK-74 5.45x39 assault rifle', '4'),
('Kalashnikov AKM 7.62x39 assault rifle', '4'),
('Kalashnikov AKS-74U 5.45x39 assault rifle', '4'),
--Bolt-action rifles
('Mosin 7.62x54R bolt-action rifle (Sniper)', '4'),
('Remington Model 700 7.62x51 blt-action sniper rifle', '4'), 
--Machine guns
('RPK-16 5.45x39 light machine gun', '4'),
--Marksman rifles
('HK G28 7.62x51 marksman rifle', '4'),
('SVDS 7.62x54R sniper rifle', '4'), 
--Pistols
('Beretta M9A3 9x19 pistol', '4'),
('FN Five-seveN MK2 5.7x28 pistol', '4'),
('Glock 17 9x19 pistol', '4'),
('Makarov PM 9x18PM pistol', '4'),
--SMGs
('HK MP5 9x19 submachine gun (Navy 3 Round Burst', '4'),
('PP-91 "Kedr" 9x18PM submachine gun', '4'),
('Saiga-9 9x19 carbine', '4'), 
('TDI KRISS Vector Gen.2 9x19 submachine gun', '4'),
--Shotguns
('MP-133 12ga pump-action shotgun', '4'),
('Mossberg 590A1 12ga pump-action shotgun', '4'),
('Saiga 12ga ver10 12/76 semi-automatic shotgun', '4'),
--Throwables
('F-1 hand grenade', '4'),
--Knifes
('Bars A-2607 95H18 knife', '4'),

--Ammo

--Rounds -- Cena ammo za sztuke
('.338 Lapua Magnum TAC-X', '5'),
('.45 ACP Match FMJ', '5'),
('5.45x39mm BT gs', '5'),
('5.45x39mm PRS gs', '5'),
('5.56x45mm M855', '5'),
('7.62x39mm PS gzh', '5'),
('7.62x51mm M61', '5'),
('7.62x54mm R LPS gzh', '5'),
('9x18mm PM PS gs PRO', '5'),
('9x19mm Pst gzh', '5'),
('9x19mm QuakeMaker', '5'),

--Provisions

--Drinks
('Bottle of water (0.6L)', '6'), 
('Bottle od Dan Jackiel whiskey', '6'),
('Can od RatCola soda', '6'), 
('Pack of Russian Army pieapple juice', '6'),
('Aqiarmari water bottle with filter', '6'),
('Pack of Apple juice', '6'),
('Can of TarCola soda', '6'), 
('Bottle of Tarkovskaya vodka', '6'),
--Food
('Army crackers', '6'), 
('MRE ration pack', '6'),
('Tushonka Can of beef stew (Large)', '6'),
('Pack of sugar', '6'),
('Can of squash spread', '6'), 
('Alyonka chocolate bar', '6'), 
('Iskra ration pack', '6'),
('Jar of DevilDog mayo', '6'),

--Medication

--Injectors
('Morphine injector', '7'),
('Zagustin hemostatic drug injector', '7'),
--Inury treatment
('Aseptic bandage', '7'),
('CALOK-B hemostatic applicator', '7'),
('CMS surglical kit', '7'),
('Esmarch tourniqet', '7'),
('Immobilizing splint', '7'),
--Medkits
('AI-2 medkit', '7'), 
('Car fist aid kit', '7'),
('IFAK individual first aid kit', '7'),
('Salewa first aid kit', '7'),
--Pills
('Analgin painkillers', '7'),
('Augmentin antibiotic pills', '7'),
('Ibuprofen painkillers', '7'),

--Keys

--Electronic keys
('TerraGroup Labs access keycard', '8'),

--Uzupe³nienie

--Barter items

--Building materials
('Pressure gauge', '1'),
('Radiator helix', '1'),
('KEKTAPE duct tape', '1'),
('Pack of screws', '1'),
('Bolts', '1'),

--Flammable materials
('Gunpowder "Kite"', '1'),
('Propane tank (5L)', '1'),
('Zibbo lighter', '1'),

--Household materials
('Alkaline cleaner for heat exchangers', '1'),

--Electronics
('T-Shaped plug', '1'),
('Bundle of wires', '1')

-------------------------------------------------------- 
-------------------------------------------------------- 

INSERT INTO Prapor(ItemID, CenaSprzeda¿y, CenaKupna, [Level])
VALUES
(1, 24000, null, null),
(6, 14350, null, null),
(8, 11419, null, null),
(9, null, 33336, 1),
(20, 64, 109,1),
(31, 6921, null, null),
(32, 3676, 10194, 1),
(33, 5000, null, null),
(34, 4000, null, null),
(35, 8892, 19385, 1),
(36, 7234, null, null),
(40, null, 2179, 1),
(41, 8931, 38938, 4),
(42, 5912, null, null),
(43, 3421, null, null),
(50, 19733, null, null),
(51, 15396, null, null),
(52, 12505, null, null),
(53, 31815, null, null),
(54, 52862, null, null),
(55, 52516, null, null),
(56, 17412, 44093, 2),
(57, 15342, 43069, 2),
(58, 8942, 24605, 2),
(59, 9172, 42203, 2),
(60, 25939, null, null),
(61, 15823, 68452, 4),
(62, 25915, null, null),
(63, 20718, 93894, 3),
(64, 6337, null, null),
(65, 7361, null, null),
(66, 6931, null, null),
(67, 3018, 6581, 1),
(68, 20319, null, null),
(69, 11521, 21349, 1),
(70, 5252, null, null),
(72, 11366, null, null),
(73, 15082, null, null),
(74, 8721, null, null),
(75, 2800, 9156, 2),
(76, 411, null, null),
(78, null, 694, 3),
(79, 23, 46, 1),
(80, 55, null, null),
(81, 41, 95, 1),
(83, 86, 319, 1),
(84, 14, 32, 1),
(85, 31, null, null),
(105, 650, null, null),
(107, 11250, null, null),
(108, 600, null, null),
(109, 927, null, null),
(110, 1625, null, null),
(112, 7426, null, null),
(113, 5894, null, null),
(114, 1900, null, null),
(115, 4587, null, null),
(116, 8411, null, null),
(118, 30600, null, null),
(120, 12000, null, null),
(121, 1570, null, null),
(122, 5500, null, null),
(123, 7000, null, null)

INSERT INTO Therapist(ItemID, CenaSprzeda¿y, CenaKupna, [Level])
VALUES
(1, 30240, null, null),
(14, 765619, 1106138, 1),
(20, 297, null, null),
(87, 1543, 12401, 1),
(88, 31500, null, null),
(89, 15107, null, null),
(90, 1345, null, null),
(91, 5418, null, null),
(92, 1078, null, null),
(93, 2507, null, null),
(94, 15750, null, null),
(95, 1513, 14665, 1),
(96, 2558, null, null),
(97, 5287, null, null),
(98, 10388, null, null),
(99, 3886, null, null),
(100, 4084, null, null),
(101, 4636, null, null),
(102, 9450, null, null),
(103, 10628, 28089, 4),
(104, 16254, 357998, 4),
(105, 819, 1949, 2),
(106, 2249, 4756, 3),
(107, 14175, null, null),
(108, 756, 1332, 1),
(109, 1168, 2677, 1),
(110, 2047, 4149, 1),
(111, 1819, 7372, 2),
(112, 9336, 27202, 2),
(113, 7427, 23162, 2),
(114, 2394, 5695, 1),
(115, 5780, 30044, 4),
(116, 10598, null, null),
(117, null, 166500, 4),
(118, 38556, null, null),
(119, 9135, null, null),
(120, 15120, null, null),
(121, 1978, null, null),
(122, 6930, null, null),
(123, 8820, null, null),
(124, 7966, null, null),
(125, 6058, null, null),
(126, 5327, null, null),
(127, 1563, null, null),
(128, 4662, null, null)

INSERT INTO Skier(ItemID, CenaSprzeda¿y, CenaKupna, [Level])
VALUES
(6, 14063, null, null),
(8, 11191, null, null),
(9, 14985, null, null),
(10, 8330, null, null),
(11, 10483, null, null),
(12, 10637, null, null),
(13, 16905, null, null),
(15, 9261, null, null),
(16, 4018, null, null),
(18, 12593, null, null),
(20, 297, null, null),
(21, 1566, null, null),
(22, 3012, 7508, 3),
(23, 2714, 7263, 1),
(24, 2009, 5658, 1),
(25, 7390, null, null),
(26, 8253, null, null),
(27, 5921, 13789, 3),
(28, 1053, null, null),
(29, 12264, 28784, 1),
(30, 19632, 59472, 4),
(31, 7001, null, null),
(32, 3582, null, null),
(33, 3900, 13800, 1),
(34, 3920, null, null),
(35, 8714, null, null),
(36, 7089, null, null),
(38, 1304, 3063, 1),
(39, 985, null, null),
(40, 979, null, null),
(41, 9211, 13522, 2),
(44, 17919, 18630, 2),
(46, null, 18670, 3),
(47, 2545, 5974, 1),
(48, 3321, null, null),
(49, 808, 1898, 1),
(50, 19338, 45388, 1),
(51, 15088, 29392, 2),
(52, 12255, null, null),
(53, 31179, null, null),
(54, 51804, null, null),
(55, 55021, null, null),
(56, 16321, null, null),
(57, 15721, null, null),
(58, 9129, null, null),
(59, 8715, null, null),
(60, 25420, null, null),
(61, 19201, null, null),
(62, 27815, null, null),
(63, 24274, null, null),
(64, 6210, null, null),
(65, 9521, null, null),
(66, 6792, null, null),
(67, 2958, null, null),
(68, 19912, null, null),
(69, 11290, null, null),
(70, 4921, 16198, 2),
(71, null, 96715, 4),
(72, 11138, 26142, 2),
(73, 14780, null, null),
(74, 8321, null, null),
(119, 7105, null, null),
(123, 6860, null, null),
(127, 1215, null, null),
(128, 3626, null, null)

INSERT INTO Peacekeeper(ItemID, CenaSprzeda¿y, CenaKupna, [Level])
VALUES
(5, 125, 244, 2),
(6, 126, null, null),
(8, 100, null, null),
(9, 134, null, null),
(10, 75, null, null),
(11, 94, 231, 2),
(20, 2, null, null),
(21, 14, 35, 1),
(22, 28, 72, 3),
(23, 24, null, null),
(24, 18, null, null),
(25, 67, null, null),
(26, 75, null, null),
(27, 51, 131, 4),
(28, 9, null, null),
(29, 111, null, null),
(31, null, 302, 4),
(32, 41, null, null),
(33, 44, null, null),
(34, 35, null, null),
(35, 79, null, null),
(36, 64, null, null),
(38, 11, null, null),
(39, 9, 23, 1),
(40, 8, null, null),
(41, 81, null, null),
(42, 48, null, null),
(43, 29, 73, 3),
(44, 168, null, null),
(45, null, 63, 2),
(47, 23, null, null),
(48, 30, 82, 1),
(49, 7, null, null),
(50, 177, null ,null),
(51, 138, null, null),
(52, 112, null, null),
(53, 285, 879, 2),
(54, 474, 1181, 3),
(55, 391, 1492, 4),
(56, 216, null, null),
(57, 147, null, null),
(58, 81, null, null),
(59, 87, null, null),
(60, 238, 440, 3),
(61, 102, null, null),
(62, 221, null, null),
(63, 112, null, null),
(64, 56, 126, 1),
(65, 94, 305, 3),
(66, 62, null, null),
(67, 27, null, null),
(68, 182, 342, 2),
(69, 103, null, null),
(72, 102, null, null),
(73, 135, null, null),
(77, null, 1, 1),
(80, null, 2, 1),
(82, null, 22, 4),
(85, null, 1, 1),
(86,  null, 3, 2),
(119, 6, null, null), 
(127, 11, null, null),
(128,34, null, null)

INSERT INTO Mechanic(ItemID, CenaSprzeda¿y, CenaKupna, [Level])
VALUES
(20, 340, null, null),
(21, 1789, null, null),
(22, 3656, null, null),
(23, 3102, null, null),
(24, 2296, null, null),
(25, 8446, null, null),
(26, 9432, 18866, 1),
(27, 6714, null, null),
(28, 1204, null, null),
(29, 14016, null, null),
(30, 23920, null, null),
(31, 7746, null, null),
(32, 5237, null, null),
(33, 5600, null, null),
(34, 4480, null, null),
(35, 9959, null, null),
(36, 8102, null, null),
(37, 42445, 110357, 3),
(38, 1491, null, null),
(39, 1126, null, null),
(40, 1119, null, null),
(41, 10259, null, null),
(42, 6584, null, null),
(43, 3714, null, null),
(44, 20477, null, null),
(45, null, 5327, 1),
(47, 2908, null, null),
(48, 3795, null, null),
(49, 924, null, null),
(50, 22101, null, null),
(51, 17244, null, null),
(52, 14006, null, null),
(53, 35633, null, null),
(54, 59205, null, null),
(55, 59175, 174030, 4),
(56, 27162, null, null),
(57, 16527, null, null),
(58, 10219, null, null),
(59, 9256, null, null),
(60, 29051, null, null),
(61, 17219, null, null),
(62, 29715, null, null),
(63, 25124, null, null),
(64, 7098, null, null),
(65, 12242, null, null),
(66, 7762, 15526, 1),
(67, 3380, null, null),
(68, 22757, null, null),
(69, 12903, null, null),
(70, 6570, null, null),
(72, 12729, null, null),
(73, 16891, null, null),
(74, 7201, null, null),
(76, 616, 1417, 4),
(77, 46, null, null),
(79, 25, null, null),
(80, 61, null, null),
(81, 46, null, null),
(83, 96, null, null),
(84, 16, null, null),
(85, 34, 70, 1),
(119, 8120, null, null),
(127, 1389, null, null),
(128, 4144, null, null)

INSERT INTO Ragman(ItemID, CenaSprzeda¿y, CenaKupna, [Level])
VALUES
(2, 11904, 23444, 1),
(3, 6979, 12496, 1),
(4, 11156, null, null),
(5, 14012, null, null),
(6, 17794, 27079, 1),
(7, 24986, 51443, 2),
(8, 14160, null, null),
(9, 18961, null, null),
(10, 10540, 22456, 1),
(11, 13264, null, null),
(12, 13459, 28917, 2),
(13, 21390, 38295, 4),
(14, 753466, null, null),
(15, 11718, 20979, 1),
(16, 5084, 10013, 1),
(17, 13282, 23780, 2),
(18, 15934, null, null),
(19, 26958,48263, 3)


INSERT INTO Jaeger (ItemID, CenaSprzeda¿y, CenaKupna, [Level])
VALUES
(1, 28800 , 166824, 2),
(2, 11520, null, null),
(3, 6754, null, null),
(4, 9627, null, null),
(14, 728161, null, null),
(15, 11340, null, null),
(16, 4920, null, null),
(18, 15420, 26985, 1),
(19, 216531, null, null),
(34, null, 8400, 1),
(36, null, 15192, 1),
(51, null, 32333, 1),
(59, 9346, null, null),
(60, 31126, null, null),
(62, null, 297669, 4),
(63, 25680, null, null),
(72, 13639, 23869, 1),
(73, 18098, null, null),
(74, 9910, 25572, 2),
(76, 3067, null, null),
(87, 1470, null, null),
(88, 30000, null, null),
(89, 14388, null, null),
(90, 1281, null, null),
(91, 5160, null, null),
(92, 1920, null, null),
(94, 13262, null, null),
(95, 1441, null, null),
(96, 2436, null, null),
(97, 5035, null, null),
(98, 9893, null, null),
(99, 2016, null, null),
(100, 3918, null, null),
(101, 2001, null, null),
(102, 9000, null, null),
(105, 780, null, null),
(106, 1982, null, null),
(107, 13500, 33075, 2),
(108, 720, null, null),
(109, 1113, null, null),
(110, 1950, null, null),
(111, 1752, null, null),
(112, 8911, null, null),
(113, 9093, null, null),
(114, 2280, null, null),
(115, 5505, null, null),
(116, 10083, null, null),
(118, 36720, null, null),
(120, 14400, null, null),
(121, 1884, null, null),
(122, 6600, null, null),
(124, 7587, null, null),
(125, 5770, null, null)

-------------------------------------------------------- 
-------------------------------------------------------- 

select * from Kategoria
select * from Itemy
select * from Prapor
select * from Therapist
select * from Skier
select * from Peacekeeper
select * from Mechanic
select * from Ragman
select * from Jaeger