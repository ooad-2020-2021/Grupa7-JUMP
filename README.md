# Tema: Covid Centar
# Tim
- Pozderac Admir
- Hasanović Ahmedin
- Dervišević Vedad

# Opis teme
Čitav svijet zahvatila je već dobro poznata pandemija Covida-19, te je prebacila čitav život(škole, posao, plaćanje ...) na online režim rada.
Covid centar olakšati će ljudima koji sumnjaju na prisustvo Covida-19 da pročitaju nešto više o samim simptomima, omogućiti će im online naručivanje za testiranje na prisustvo Covid-19.
Covid centar, povezan sa svim domovima zdravlja će da prati i broji broj zaraženih, broj izliječenih, broj hospitalizovanih. Također, moguć je uvid u broj vakcina u državi,
broj vakcinisanih, te je moguće(ukoliko osoba ispunjava određene uvjete) naručiti se za vakcinaciju. U covid centru moguće je pratiti u globalnu sliku broja zaraženih iz svih 
zemalja svijeta(koje objave dnevni podatak o broju zaraženih).

# Detaljna specifikacija 

**Online pregled(Odabir simptoma), opis simptoma**
Kroz online pregled korisniku centra biti će ponuđeno da odabere različite simptome koje prouzrokuje sam virus, u dodatnoj sekciji moći će dodatno opisati svoje stanje te uputiti hitnu poruku doktoru
**Online naručivanje za testiranje**
Nakon samog pregleda i mišljenja doktora, ukoliko je doktor predložio testiranje, korisnik centra će jednostavnim klikom odabrati dan za testiranje, a od sistema će dobiti povratnu poruku koja će sadržati: Broj kabine, tačno vrijeme u kojem osoba treba biti u redu za testiranje(period će biti izračunat na osnovu prosječnog trajanja testiranje jedne osobe i do tada već naručenih osoba na testiranje u tom danu)). Također, ukoliko osoba ne može biti u tom periodu biti prisutna, moći će ručno odabrati tačno vrijeme i pridržavati se istoga.
**Rezultati testiranja**
Testiranoj osobi bi u roku od nekoliko sati trebala stići poruka koja sadržava nalaz testiranja, u nalazu će stajati nalaz, mišljenje i savjeti ljekara


# Funkcionalnosti 
- Online pregled(Odabir simptoma), opis simptoma, te na osnovu toga odluka o testiranju
- Online naručivanje za testiranje na prisustvo Covid-19
- Online detaljni rezultati testiranja
- Praćenje broja zaraženih u državi, broja hospitalizovanih, izliječenih, lakših i težih oboljenja
- Praćenje popunjenosti kapaciteta Covid bolnica u državi
- Praćenje broja vakcina u državi, te praćenje broja vakcinisanog stanovništva
- Online proces naručivanja i prijave za vakcinaciju
- Praćenje globalne slike svijeta o broju zaraženih

# Procesi
- Gost(Mogući pacijent): 
  - Odabir simptoma, opis trenutnog stanja
  - Razgovor za dežurnim doktorom
  - Naručivanje za testiranje
  - Primanje rezultata u inbox
  - Uvid u sve ključne brojeve(Broj zaraženih, izliječenih, hospitalizovanih)
  - Uvid u načine liječenja
  - Uvid u sve ključne brojeve vezane za imunizaciju stanovništva(Broj vakcina, broj vakcinisanih broj naručenih za vakcinaciju)
  - Uvid u svoj zdravstveni karton
  - Naručivanje za vakcinaciju
  - Primanje obavijesti i napomena o terminu testiranja i vakcinisanja
- Doktor: 
  - Pregled simptoma pacijenata
  - Davanje svog mišljenja i analiza pacijenta, preporuka za testiranje
  - Izdavanje uputnice za testiranje
  - Izdavanje uputnice o hospitaliziranju pacijenta
  - Pregled zahtjeva za vakcinaciju 
  - Stalni uvid u zdravstvene kartone svih pacijenata
- Admin:
  - Dnevno ažuriranje brojeva zaraženih kako u državi tako i u svijetu
  - Dnevno ažuriranje broja vakcinisanih
  - Pregled svih dostupnih ljekara
  - Pregled svih prijavljenih pacijenata
- Akteri:
  - Potencijalni pacijent(Posjetitelj Covid centra)
  - Pacijent
  - Doktor
  - Administrator  
  
 
