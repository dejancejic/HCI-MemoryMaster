   M S B A M L   `   `   `  ����U  QSystem.Runtime, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a7,clr-namespace:System;assembly=System.RuntimeSystem  5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   	startGame  newLevel  myLevel  chooseLevel  chooseLevelLbl  	InfoLevel  
levelLabel  play  mainMenu 	 	highScore 
 bestTime  addLevelTitle  enterLevelName  imagesPicked  levelNameTextSize  	errorText  pickNewImage  addLevel  levelNameEmpty  notEnoughImages  enoughImages  selectCorrectFileType  imageAlreadyExists  
levelAdded  errorInFile  errorWritingFile  levelAlreadyExists 	 score  time  prevousBest  previousTime  congradulations   myLevels ! sureToDeleteLevel " confirmation # updateLevel $ 
updateName 
% update & updateImages ' updatedLevel ( deletedLevel ) success 	* start + searchLevel , language - loading . appInfo�� 5      F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml     5      7System,clr-namespace:System;assembly=System.Runtime  5      %�  &	        &	 #     &	 E     &	 g     &	 �     &	 �     &	 �     &	 �     &	     &		 =    &	
 g    &	 �    &	 �    &	 �    &	     &	 [    &	 z    &	 �    &	 �    &	 �    &	 +    &	 _    &	 �    &	 �    &	     &	 Q    &	 �    &	 �    &	 �    &	 �    &	 &    &	 P    &	  s    &	! �    &	" �    &	#     &	$ G    &	% u    &	& �    &	' �    &	( �    &	) '    &	* H    &	+ k    &	, �    &	- �    &	. �    ��5      Počni igru��62   ��5      
Dodaj Nivo��61   ��5      
Moji nivoi��60   ��5      MemoryMaster - Nivoi��6>   ��5	      Izaberite nivo:��6<   ��5
      Podaci o nivou:��67   ��5      Nivo��6-   ��5      	Igraj��6(   ��5      Glavni Meni��62   ��5      Najbolji Rezultat:��6:   ��5      Najbolje Vrijeme:��68   ��5      "MemoryMaster - Dodaj Novi Nivo��6J   ��5      Unesite ime nivoa��6>   ��5      Izabrane Slike��69   ��5      2.Ime nivoa ne smije biti duže od 20 karaktera!��6]   ��5      Greška��6.   ��5      Izaberite Novu Sliku��6?   ��5      
Dodaj Nivo��61   ��5      #Ime nivoa ne smije biti prazno!��6L   ��5      Dodajte bar 2 slike!��6B   ��5       Maksimalan broj slika je 12!��6G   ��5      IEIzabrani fajlovi moraju imati jednu od ekstenzija: jpg, jpeg ili png!��6y   ��5      Slika je već dodana!��6E   ��5      !Novi nivo je uspješno dodan!��6E   ��5      Greška pri čitanju fajla!��6C   ��5      Greška pri upisu u fajl!��6G   ��5      $ Nivo sa tim imenom već postoji!��6P   ��5       	Rezultat:��6-   ��5!      Vrijeme:��6+   ��5"      Prethodni Rezultat:��6=   ��5#      Prethodno Vrijeme:��6=   ��5$      Čestitamo!��68   ��5%      MemoryMaster - Moji Nivoi��6@   ��5&      84Da li ste sigurni da želite da obrišete ovaj nivo?��6b   ��5'      Potvrda��62   ��5(      $ MemoryMaster - Ažuriranje nivoa��6I   ��5)      Ažurirajte Ime Nivoa:��6>   ��5*      Ažurirajte Nivo��64   ��5+      Ažurirajte Slike��6;   ��5,      Uspješno ažuriran nivo!��6B   ��5-      Uspješno obrisan nivo!!��6B   ��5.      	Uspješno��6.   ��5/      Počni Igru��6.   ��50      !Pretražite po imenu nivoa...��6F   ��51      
Jezik:��6-   ��52      Učitavanje��60   ��53      �
�
Igra pogađanja slika (MemoryMaster) 


    MemoryMaster je igra u kojoj korisnik na osnovu određenog broja kartica sa slikama na sebi, pokušava da pronađe odgovarajući par istih slika i tako otkriva kartice sve dok ne otkrije svaku kombinaciju. 
    

    Sama aplikacija sadrži nekoliko proizvoljnih nivoa, a kreću se od najlakšeg do najtežeg. 
    Pored toga postoji i mogućnost da korisnik sam napravi svoj nivo, odnosno da izabere svoje proizvoljne slike za svoj novi nivo. Za korisnički definisane nivoe, pored prikaza svih i pretrage po imenu, postoji i mogućnost izmjene slika (uklanjanje, ažuriranje postojeće kao i dodavanje novih slika) te imena nivoa. 
    

    Za svaki nivo prikazuje se vrijeme prelaska datog nivoa, a po završetku nivoa prikazuje se i broj bodova koji je korisnik ostvario na datom nivou u zavisnosti od vremena prelaska i broja tačno pogođenih parova te broja promašaja.
    

    Pored toga, za svaki nivo se prikazuje i najbolji rezultat koji je korisnik ostvario na svakom od nivoa, kako u predefinisanim nivoima u aplikaciji tako i u sopstvenim nivoima.
    

    Sve slike su raspoređene sasvim slučajno u svakom nivou i pri svakom novom pokretanju istog. 

 Aplikacija je kreirana u novembru 2024. godine.
    

Autor: Dejan Ćejić��5>   %   5?      