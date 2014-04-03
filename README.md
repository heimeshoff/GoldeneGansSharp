GoldeneGansSharp
================

GoldeneGans implementiert in C#

---

Seid gegrüßt in der Goldenen Gans.

Wie ihr wisst, sind wir ein kleiner Gemischtwarenhandel mit Hauptsitz in der Hauptstadt, 
geführt vom stets behüteten Herrn Haupt. Wir kaufen und verkaufen nur die edelsten Waren, 
aber der verderblichen Natur dieser Waren ist es zu verdanken, dass diese ständig an Wert verlieren.

Wir haben uns vom akkuraten Herrn Andersson ein System erstellen lassen, 
das unser Inventar regelmäßig aktualisiert, aber Andersson ist aufgebrochen zu neuen Abenteuern. 
Eure Aufgabe soll es daher sein, neue Funktionalität in das System zu bringen, 
so dass wir in Kürze eine neue Kategorie von Waren verkaufen können. 

Vorweg eine kurze Einführung in unser System:
  - Alle Waren haben einen VerkaufenIn-Wert. 
    Dieser gibt die Anzahl der Tage an, in denen wir die Ware verkaufen müssen.
  
  - Alle Waren habenen einen Qualitäts-Wert.
    Er definiert, wie wertvoll die Ware ist. 

  - Am Ende eines Tages verringert unser System beide Werte für alle Waren.

Klingt soweit recht einfach, nicht wahr? Nun, das folgende wird es spannender gestalten:
  - Sobald das ersehnte Verkaufsdatum überschritten ist, sinkt die Qualität doppelt so schnell.

  - Die Qualität einer Ware ist niemals negativ.

  - Die Qualität von "Alter Gouda" steigt sogar, je älter er wird.  

  - Keine Ware kann eine Qualität über 50 erlangen.

  - "Fedoras", der legendäre Hut des ehemaligen Besitzers, 
    muss niemals Verkauft werden, und verliert nie an Qualität.

  - "Backstage-Pässe", wie "Alter Gouda", steigen im Wert, je näher sie ihrem Verkaufsdatum kommen.
    Die Qualität steigt um 2, wenn nur noch 10 Tage oder weniger übrig sind,
    und sie steigt um 3, bei nur noch 5 Tagen oder weniger bis zum Konzert.


Um das Geschäft zu neuen Höhen zu treiben, hat Herr Haupt kürzlich seine Seele an einen Händler verkauft,
der uns seither mit arkanen Waren beliefert.
  - Arkane Waren verlieren doppelt so schnell an Qualität wie normale Waren.  

Fühlt euch ganz frei, die "aktualisiere_qualitaet" Funktion zu verändern und neuen Code zu schreiben, 
solange alles bisherige Verhalten weiterhin korrekt seinen Dienst tut.

Viel Erfolg wünscht
Das Team der Goldenen Gans

    "THE PIZZA-WARE LICENSE":
    As long as you retain this notice you can do whatever you want with this stuff. 
    If we meet some day, and you think this stuff is worth it, 
    you can buy me a pizza in return.
