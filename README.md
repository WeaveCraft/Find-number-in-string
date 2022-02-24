# Find-number-in-string
(School project from Nyköping Campus)
First project from Programming in .Net C# 1 

VG uppfyllt.
2021-09-14

Inledning
Skapa en konsollapplikation som tar en textsträng (string) som argument. Den kan
också läsa in det via Console.ReadLine(), men det räcker med en hårdkodad
textsträng.
Textsträngen ska sedan sökas igenom efter alla delsträngar som är tal som börjar
och slutar på samma siffra, utan att start/slutsiffran, eller något annat tecken än
siffror förekommer där emellan.
ex. 3463 är ett korrekt sådant tal, men 34363 är det inte eftersom det finns
ytterligare en 3:a i talet, förutom start och slutsiffran. Strängar med bokstäver i
t.ex 95a9 är inte heller korrekta tal.

Skriv ut och markera varje korrekt delsträng
För varje sådan delsträng som matchar kriteriet ovan ska programmet skriva ut en
rad med hela strängen, men där delsträngen är markerad i en annan färg.
Exempel output för input ”29535123p48723487597645723645”:

Ni kan välja vilka färger ni skriver ut med så länge man ser skillnad på dem. Ni
byter färg genom att ändra värde på Console.ForegroundColor.
Addera ihop alla tal och skriv ut totalen
Programmet ska också addera ihop alla tal den hittat enligt ovan och skriva ut det
sist i programmet. Gör gärna en tom rad emellan för att skilja från output ovan.
Exempel output för input ”29535123p48723487597645723645”:
Total = 5836428677242

Redovisning
Uppgiften ska lösas individuellt.
Lämna in uppgiften på Moodle med en kommentar med github-länken.

Betygskriterier
För godkänt:
• Det räcker att lösa en av uppgifterna, d.v.s. antingen skriva ut alla
delsträngar som i exemplet ovan, eller räkna ut och skriva ut totalen.
• Om man matar in strängen i exemplet ska man få samma output som ovan.
• Det ska även fungera generellt, oavsett vilken sträng man matar in.

För väl godkänt krävs även:
• Båda uppgifterna ska vara lösta, d.v.s. programmet ska först skriva ut alla
delsträngar som i exemplet ovan och därefter räkna ut och skriva ut total.
• Koden ska vara väl strukturerad och lätt att förstå.
• Allting ska fungera vid inlämning. Gör det inte det så kommer ni att få
tillbaks uppgiften med möjlighet att fixa det som krävs för godkänt. Men
ni har alltså bara en chans på er att få VG. Så var noga med testning.
• Inlämning sker före deadline.
