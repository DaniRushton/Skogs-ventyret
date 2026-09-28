# Rapport

**Kurs:** Grundläggande OOP i C#  
**Uppgift:**  Slutuppgift Skogsäventyret
**Grupp:**  Team Jango Fett
**Datum:**  2026-09-28
**GitHub:**  https://github.com/DaniRushton/Skogs-ventyret.git

---

## Gruppmedlemmar

| Namn | Lämnade in |
|------|-----------|
| [Daniella] | Zip + RAPPORT.md + REFLEKTION.md |
| [Lazo] | REFLEKTION.md |
| [Murtaza] | REFLEKTION.md |

---

## G — Hur vi löste uppgiften

> Förklara kortfattat hur du löste varje G-krav. En till tre meningar per punkt räcker.  
> Skriv med egna ord — kopiera inte uppgiftsbeskrivningen.

### Klasserna

> Monster-basklassen har privata fält och auto-properties { get; private set; }, i dessa har vi satt i monstrets
  namn, hp, attack, xp och defense enligt krav. Efter basklassen för Monster var gjord kunde vi gå över till att
  skapa självaste monstrena där vi skapade tre olika med sina egna startvärden i konstruktorn för att slippa
  skapa nya klasser för varje nytt monster.

### Metoderna

> TakeDamage(int damage) minskar hp och ser till att hp:n aldrig går under 0. i det fall att hp:n blir 0 så
  returnar den att objektet är dött och anropar koden som säger att striden är över.
  AttackPlayer(Player player) låter monstret attackera spelaren och skriver ut vem som attackerar vem och hur
  mycket skada det blir. Anropar också player.TakeDamage() för att skadan faktiskt skall ske
  MonsterSpawner.SpawnRandomMonster() använder Random för att slumpa fram ett nytt objekt (monstertyp) varje 
  runda istället för att koden skall återanvända samma potentiellt döda monster runda efter runda. 

### Main()

> I Main() så efterfrågas spelaren sitt namn. Därefter körs MonsterSpawner som skapar ett nytt monster vid
  rundans start. Sedan kommer en while-loop som tillåter spelaren att välja mellan att 1) attackera, 2)
  försvara eller 3) springa, alla dessa skadar spelare med olika variabler; 1) baserat på monstrets attack-
  styrka, 2) baseras på hälfen av monstrets styrka, 3) random skada baserat på monstrets styrka.

### Git

> Vi har skapat ett gemensamt repo på GitHub som vi arbetat i tillsammans i våra egna commits för att kunna 
  tilldela ansvar av olika delar av koden som Monster eller Player- hierarkierna till varandra. Vi har använt 
  git pull för att 'ladda ner' varandras ändringar som finns på GitHub lokalt och sedan commitat och pushat 
  vår del av koden till GitHub, allt för att undvika att vår kod skriver över någon annans.

### Kodkvalitet

> Vi har gett variabler och metoder tydliga och beskrivande namn för att tydliggöra vad de gör, exempelvis
  SpawnRandomMonster som spawnar ett random monster. Kommentarer har också satts där koden inte är tydlig
  vad den gör, exempelvis vid skadeberäkningen för varje stridsval.

---

## VG — Motivering

> Fyll i det här avsnittet om du siktar på VG. Lämna tomt = G-bedömning.

### Vad vi lade till

> 

### Varför vi löste det såhär

> 

---

## Git-logg

Klistra in utskriften från `git log --oneline` här:

```
[klistra in här]
```