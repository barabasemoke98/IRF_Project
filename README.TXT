A szoftver funkciói:

A szoftvert egyszerű csv-ből való lekérdezés céljából hoztam létre, amelyekből valós adatokat láthatunk a koronavírus esetszámairól világszerte.

Alap esetben a Show Data, a kontinens és a kontinenshez tartozó ország választó inaktív, továbbá az országok esetszámainak összehasonlítására szolgáló "Where are more cases?" gomb is.
Amennyiben a Load CSV gombbal beolvasunk egy CSV filet, a gombok és  legördülő listák aktívvá válnak (beolvashato file hozzá a covidnew.csv - elérés: TBCJ6C_IRF_beadando\TBCJ6C_IRF_beadando)
Ebben a fileban szerepelnek rendre napok, hónapok, évek, esetszámok, halálos esetszámok, országok és kontinensek. 
A Show Data gomb használatához ki kell választanunk egy megfelelő időintervallumot (ennek elegendőnek kell lennie a lekérdezéshez), de választhatunk a gomb melletti legördülő listából kontinenst (1. legördülőlista) és az adott kontinenshez tartozó országot (2. legördülőlista) 
Ezután a Show Data gombra való kattintással a megfelelő adatok bekerülnek a lekérdezésbe, továbbá egy szemléltető diagrammot is láthatunk a lekérdezés mellett, aminek vízszintes (x) tengelye az idő és a függőleges (y) tengelye az esetszám. 
A "Where are more cases?" gomb segítségével az alatta található két legördülő lista elemei (összes érintett ország) között állapíthatunk meg relációt. Amennyiben kiválasztunk 1-1 országot, és a gombra kattintunk, az időintervallumnak megfelelően összeadja az esetszámokat a két választott országhoz tartozóan és a közöttük található label megmutatja (</>/=), hogy melyik országban volt több esetszám a dátumnak megfelelően.
