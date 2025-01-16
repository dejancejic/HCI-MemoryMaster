# HCI-MemoryMaster

### Uvod

  ***MemoryMaster*** je video igra koja je zasnovana na popularnoj društvenoj igri - "Memorija". Korisnik otkriva jednu karticu i traži karticu koja ima istu sliku. Ukoliko pronađe sliku dobija poene(više poena za manji broj neispravnih pokušaja). Sama aplikacija posjeduje 8 nivoa, s tim da korisnik može da definiše sopstvene nivoe i upravlja istima.

  ### Arhitektura aplikacije
 Aplikacija je napisana u programskom jeziku C# koristeći Windows Presentation Foundation(WPF) framework i koristi bazu podataka u vidu datoteke kao glavni način čuvanja podataka. Za korištenje aplikacije potreban je računar(desktop ili laptop) te odgovarajuće okruženje za pokretanje same aplikacije.


 ## Početna stranica
   Na početnoj stranici se nalaze opcije za početak igre, kreiranje novog sopstvenog nivoa, pregled(upravljanje) i igranje sopstvenih nivoa, promjena jezika te dugme sa opcijom za prikaz informacija o autoru i aplikaciji.
   
![image](https://github.com/user-attachments/assets/4a4a8702-d027-41ca-a081-da01204c2176)
<p align=center>Početna stranica</p>

## Stranica za prikaz informacija o aplikaciji
Na ovoj stranici se prikazuju informacije o aplikaciji kao i o autoru aplikacije. Za napuštanje je potrebno kliknuti na dugme za izlazak u vrhu.

![image](https://github.com/user-attachments/assets/f63a170c-8c9c-421d-801b-91dc79b3a890)
<p align=center>Informacije o aplikaciji</p>

## Stranica za prikaz nivoa
Ovdje se nalazi prikaz svih nivoa ugrađenih u aplikaciji(ukupno 8). Korisnik bira jedan od nivoa koji želi da igra pri čemu mu se prikazuju naziv, najbolje vrijeme i najbolji rezultat za dati nivo te dugme za igranje nivoa. Takođe tu je i dugme za povratak na glavni meni.

![image](https://github.com/user-attachments/assets/9ce1d9c5-0de5-4e22-957f-7e03f3e92a8d)
<p align=center>Stranica za prikaz nivoa</p>

## Stranica za dodavanje nivoa
Na ovoj stranici korisnik može da definiše ime novog nivoa, kao i da doda nove slike(minimalno 2), ali i da ih ukloni nakon dodavanja istih. Kada se  klikne na dugme za dodavanje slike otvara se forma za pretragu fajlova(sistemska) u kojoj se biraju slike(samo slike se mogu izabrati, pojedinačno). Klikom na dugme za dodavanje nivoa provjeravaju se informacije i kreira se novi nivo koji se može igrati odlaskom na stranicu sopstvenih nivoa.

![image](https://github.com/user-attachments/assets/057b4d57-d3de-487a-9a5e-5534a6794535)
<p align=center>Stranica za dodavanje nivoa</p>

## Stranica za prikaz sopstvenih nivoa
Na stranici za prikaz sopstvenih nivoa, moguće je izmjeniti date nivoe(ime i slike) klikom na ikonicu za ažuriranje pored samog nivoa. Takođe moguće je i izbrisati neki nivo klikom na ikonicu za brisanje. Pored toga moguće je i igrati izabrani nivo klikom na dugme za igranje nivoa. Tu se nalazi i search bar koji omogućava pretragu nivoa po imenu.

![image](https://github.com/user-attachments/assets/4637f346-888f-40fd-a7fb-48adafb242f8)
<p align=center>Stranica za prikaz sopstvenih nivoa</p>

## Stranica za ažuriranje nivoa
Na ovoj stranici korisnici mogu ažurirati slike, dodati nove, obrisati neke kao i promjeniti ime nivoa.

![image](https://github.com/user-attachments/assets/aacc8372-94f2-4344-9aa6-9b892f2711cb)
<p align=center>Stranica za ažuriranje nivoa</p>

## Stranica za igranje izabranog nivoa
Nakon izbora opcije za igranje nivoa, korisnik može da igra nivo. Ovdje se prvo mora pritisnuti dugme za igranje na stranici kako bi brojanje vremena i otkrivanje kartica moglo početi.

![image](https://github.com/user-attachments/assets/722f34d3-a170-4b49-839c-b4f8bfe64e20)
<p align=center>Stranica za igranje nivoa</p>

Nakon uspješno završenog nivoa prikazuje se mali prozor sa obavještenjem o uspješnosti. U svakom trenutku je moguće napustiti nivo klikom na dugme za izlazak u vrhu.

![image](https://github.com/user-attachments/assets/ebc8bfe4-049d-4de4-9cc7-d2fca7646f24)
<p align=center>Uspješno završen nivo(obavještenje)</p>



