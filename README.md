Instruktioner för "Axels Dagboksapplikation"
För att starta applikationen:
Klona projektet och öppna det via Visual Studio. 
För att köra programet tryck f5 eller tryck på play knappen.
När man startar consolapplikationen så får man 6 st alternativ, du kan skapa anteckningar, lista anteckningar, söka anteckningar efter specifika datum, spara/ladda anteckningar till/från fil och avsluta programet.

Input:
"Ange antecknings innehåll"
Hejsvejs. 
Output:
2025-10-02 - Hejsvejs.

Reflektion:
Jag försökte lägga till samtliga funktioner från start, för att åstadkomma VG betyg, men funktioner som att ta bort inlägg och uppdatera inlägg fick jag inte att fungera.
Det gjorde att koden vart väldigt förvirrande när jag började skala bort onödig kod och jag fick skriva om och plåstra ihop en lösning tillslut.
Jag började med en lista för att lagra nya anteckningar, men fick det inte att fungera när jag skulle uppdatera befintliga anteckningar, via internet och Copilot så lyckades jag lösa lagringen av anteckningar via en Dicationary<Datetime, Diaryentry>.
När jag tog bort uppdateringar från programet så valde jag att ha kvar det nya sättet att lagra anteckningarna på, kvarlevor från tidigare lösning finns säkertkvar att skåda.
Jag hade mycket problem med input/output som jag löste genom att skapa två metoder PostEntry och PreEntry i klassen EntryDisplay, som gjorde att outputen vart snyggare för användaren och det tog bort mycket kodrader från funktionerna i DiaryChoices.

Det var väldigt utmanande, filhantering och git känner jag att jag måste verkligen sätta mig mer med. Jag förstod inte direkt git förrens torsdagen den 2025-10-02 mycket pga att jag missade lektioner tidigt. 
Jag känner dock mig otroligt mer bekväm just nu och får helt enkelt utmana mig själv och skapa fler applikationer där jag använder git fler gånger.
Jag missade git commit delarna och försökte lägga till de på slutet, men kommentarerna och koden som ändras är inte gjorda samtidigt.
