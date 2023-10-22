Einige TV Modelle und Sat-Empf�ngerboxen unterschiedlicher Marken verwenden die gleiche Tuner-Hardware (inkl. Firmware 
und Dateiformaten) von Drittherstellern, somit werden auch einige Marken und Modelle unterst�tzt, die
hier nicht explizit angef�hrt sind.  
Andererseits kommt es auch vor, dass ein Hersteller f�r einige Modelle ein Dateiformat verwendet, das von ChanSort
(noch) nicht unterst�tzt wird.

<a name="samsung"/>Samsung
---
- .scm Dateien: Serien B (2009)*, B (2013), C, D, E, F, H, J  
- .zip Dateien: Serien H, J, K, M, N, Q, R  

\*: Das "clone.bin"-Format ist nicht unterst�tzt. Im "*.scm"-Format
der 2009 B-series werden in der "Air Analog"-Liste nicht alle Bearbeitungsfunktionen
unterst�tzt.

Eine Anleitung zum Transfer der Senderliste befindet sich hier:
https://github.com/PredatH0r/ChanSort/wiki/Samsung

<a name="lg"/>LG
---
- Serien basierend auf Netcast OS, die eine xx\*.TLL-Datei exportieren:  
  CS, DM, LA, LB\*, LD, LE, LF, LH, LK, LM+, LN, LP#, LS, LT, LV, LW, LX, PM, PN, PT, UB\*  
- Serien basierend auf webOS 2-5, die eine GlobalClone00001.TLL-Datei exportieren

\*: Einige Ger�te verhalten sich fehlerhaft aufgrund Probleme in deren Firmware.  
+: xxLM640T kann aufgrund von Firmwarem�ngeln nicht unterst�tzt werden.  
\#: Nur Satellitensender werden unterst�tzt.

Modelle mit NetCast Betriebssytem beinhalten keine Import/Export Funktion im normalen Men�. Um das Geheimmen� aufzurufen,
halten Sie die Settings Taste auf der Fernbedienung solange gedr�ckt, bis das Men� wieder verschwindet und dann dr�cken Sie "1105".
Im "TV Link Loader" Men� befinden sich dann die Import/Export-Funktionen.

WICHTIG: Es ist NOTWENDIG bei der Sendersuche spezielle Optionen auszuw�hlen. Wenn ein Anbieter / Land / Satellit bei der Suche
ausgew�hlt wird, erh�lt man eine vorsortierte Liste und der TV verh�lt sich nach einem Export+Import fehlerhaft.
W�hlen Sie immer "Keiner / Anderer / Alle" aus bzw. "Blindsuche", und nie einen Kabelanbieter oder "Astra 19.2 Liste".

<a name="sony"/>Sony
---
- Android-TVs: "sdb.xml" Dateien mit Version "FormateVer" 1.1.0
- KDL 2012/2014: "sdb.xml" mit "FormatVer" 1.0.0, 1.1.0 and 1.2.0

<a name="hisense"/>Hisense
---
- Einige �ltere Modelle wie LTDN40D50TS verwenden die gleichen .csv Dateien wie Sharp. Siehe "Sharp" f�r eine Anleitung.
- Smart-Modelle (2016) mit channel.db Dateiformat, z.B. H65M5500  
- 2017 Modelle mit einem servicelist.db Dateiformat
- Modelle die eine HIS_DVB.BIN Datei exportieren
- Modelle die eine Gruppe aus HIS\_FAV.BIN, HIS\_SVL.BIN und HIS\_TSL.BIN Dateien exportieren

Besonderen Dank verdient Hisense f�r die Bereitstellung von technischen Informationen und einem Testger�t!

<a name="panasonic"/>Panasonic
---
**Android-TVs** gibt es mit unterschiedlicher interner hardware, firmware und Senderlistenformaten. Unterst�tzt werden
- mnt/vendor/tvdata/database/tv.db file (LSW500 and LXW700 series)
- channellist.txt (MX700, MZ800)
- channels.sdx ("fire-OS" MXW834)
- NICHT unterst�tzt: CLONE00001/settingsDB\_enc.db (JXW600)
- NICHT unterst�tzt: hotel\_setup/Channel\_list/channel\_list.bin (JXW800)
Bei einigen Modellen kann man die Senderliste importieren/exportieren, indem man "Input: Kabel" (oder eine andere TV-Quelle)
und dann im Men� den Punkt "Kanal".
Bei anderen Modellen ist eventuell nur der Umweg �ber das geheime Hotel-Men� m�glich:
Men� / Bild / Bildmodus / Benutzerdefiniert / Kontrast / 6x Ok.

**Viera** Modelle mit Senderlisten im Format
- svl.bin 
- svl.db (JZT1500, ...)
Zum Exportieren/Importieren wird ein USB stickmit FAT32 ben�tigt, auf dem man eine leere Datei oder ein Verzeichnis
mit dem Namen "hotel.pwd" erstellt. Nach dem Anstecken an den TV kann man den codes 4850 f�r TV->USB oder 4851 f�r
USB->TV eingeben.

<a name="tcl"/>TCL / Thomson
---
TVs die ein .tar Archiv mit enthaltener database/cloneCRC.bin und database/usedata/DtvData.db Datei exportieren  
(Diverse TCL Android / Google TV modelle)

<a name="philips"/>Philips
---
Philips verwendet unz�hlige unterschiedliche Dateiformate f�r diverse TV-Modelle.
ChanSort unterst�tzt derzeit folgende Formate:
- PhilipsChannelMaps\ChannelMap_45, 100, 105 und 110
- Repair\ChannelList\channellib\\\*Table and s2channellib\\\*.dat
- Repair\CM_TPM1013E_LA_CK.xml (diese Datei ist oft versteckt und nur eine .bin Datei sichtbar)

<a name="sharp"/>Sharp (and some models from Dyon, Blaupunkt, Hisense, Changhong, alphatronics, JTC Genesis)
---
Einige dieser TVs verwenden �hnliche Hardware und k�nnen .csv Dateien exportieren/importieren, um die Reihenfolge zu �ndern:  
- DVBS_Program.csv (mit cvt_database.dat)
- DVBS_CHANNEL_TABLE.csv (mit dtv_cmdb\*.bin)
- MS\*_DVBS_CHANNEL_TABLE.csv (mit MS\*_HOTELMODE_TABLE.json)

Blaupunkt B40A148TCSFHD, B32B133T2CSHD, ...  
Changhong LED32E2200ST2, ...  
Dyon Live 22 Pro, Live 24 Pro, ENTER 32 Pro X, ...  
Hisense LTDN40D50TS, ...  
Sharp LC-xxCFE4142E, LC-xxCFF6002E, LC-xxFI5542E, LC-xxFG5242E, LC-xxUI7552E, LC-xxUI7652E, xxBJ1E, xxBJ3E, xxBJ5E, ...  
Grundig 24 GHB 5944  

Abh�ngig vom konkreten TV-Modell kann die Import/Export-Funktion Teil des normalen Men�s, eines Hotel-Men�s oder Service-Men�s sein
und die exportieren Dateien unterschiedlich sein. Einige Modelle wie Sharp Aquos xxBJ1E haben ein Untermen� f�r den Export. Hier
sind alle 4 Typen von Dateien f�r einen Import n�tig.  
Um in das geheime Hotel- / Service-Men� zu gelangen, gibt es verschiedene Tastenkombinationen auf der Fernbedienung:  
Hotelmenu: MENU 7906 / MENU 4588  
Servicemenu: MENU 1147 / MENU 11471147 / SOURCE 2580  
�ndern Sie keine Werte im Servicemen�, dies k�nnte den Fernseher besch�digen. Nutzen Sie nur die Import/Export-Funktionen.

<a name="toshiba"/>Toshiba
---
- Modelle, die eine .zip-Datei mit folgendem Inhalt: chmgt.db, dvbSysData.db und dvbMainData.db.  
(z.B. RL, SL, TL, UL, VL, WL, XL, YL models of series 8xx/9xx)  
- Modelle mit einer settingsDB.db Datei

<a name="grundig"/>Grundig
---
- Modelle die Dateien mit Namen dvb\*_config.xml exportieren.
- Modelle die eine cvt_database.dat Datei exportieren, z.B. 24 GHB 5944: siehe "Sharp"
- Modelle die eine Reihe von \*\_cmdb\_\*.bin Dateien exportieren.

<a name="medion"/>
---
- Android Smart TVs mit einer "senderliste.txt" Exportdatei (die Textzeilen im JSON-Format enth�lt), e.g. X15567 (MD 31555)
- Modelle mit .sdx Listen (siehe SatcoDX)

<a name="satcodx"/>SatcoDX (Lieferant f�r ITT, Medion, Nabo, ok., PEAQ, Schaub-Lorenz, Silva-Schneider, Telefunken)
---
Mehrere Marken nutzen die gleiche Hardware f�r DVB-S und exportieren .sdx Dateien

<a name="dbm"/>Xoro, TechniSat, Strong, ...
---
Mehrere Marken nutzen die gleiche Hardware f�r DVB-S und DVB-C Receiver, die .HBM Dateien in unterschiedlichen Varianten exportieren.

<a name="visionedge"/>VISION EDGE 4K
---
database.db Datei, die von dieser DVB-S/C/T Set-Top-Box exportiert wird

<a name="vdr"/>VDR (Linux Video Disk Recorder)
---
Unterst�tzung des channels.conf Dateiformats.  
Die Implementation hierf�r wurde vom Mitglied "TCr82" des VDR Projekts beigesteuert.

<a name="m3u"/>m3u (SAT>IP)
---
Unterst�tzt SAT>IP .m3u Dateien mit erweiterten Informationen zu Sendernamen und Programmnummern.

<a name="enigma2"/>Enigma2 (Dreambox, VU+ und viele andere Linux basierende Empf�nger)
---
Erfordert eine lokale Kopie der Dateien "lamedb", "bouquets.\*" and "userbouquet.\*" aus /etc/Enigma2/.  
