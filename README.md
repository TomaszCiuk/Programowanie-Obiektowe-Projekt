Projekt Programowanie Obiektowe 
 
Tomasz Ciuk 

Daniel Czopek 

 

Tytuł: Tarkov Calculator

Założenia ogólne projektu: 

Escape From Tarkov, gra stworzona przez studio Battlestate Games, jest jedną z bardziej skomplikowanych produkcji dostępnych na rynku. 
Jednym z głównych celów gry jest zbieranie przedmiotów znalezionych podczas rajdów (gracz zostaje wrzucony na mapę, 
z której musi uciec zbierając przy okazji jak najwięcej itemów) Gracz może je sprzedać jednemu z ośmiu traderów. 

Aplikacja ma za zadanie wskazać który z traderów  kupuje dany przedmiot, jeśli więcej niż jeden to który z nich więcej płaci. 
Z drugiej strony przez aplikację można sprawdzić u którego tradera można kupić podany item. 

Baza danych w SQL server


Tabela z itemami 

Kolumny: 

1.ID 

2.Nazwa 

3.Kategoria 


Tabela traderów (w nazwie tabeli imie tradera) 

6 tabeli z każdym traderem (Prapor, Therapist, Skier, Peacekeeper, Mechanic, Ragman, Jaeger) 

Kolumny: 

1.intem ID 

2.Cena sprzedaży 

3.Cena kupna 

4. Level (na którym można kupić item) 


Tabela z kategoriami 

Kolumny: 

1 ID kategorii 

2.Nazwa kategorii 

 

Warstwa wizualna 


Założenie ogólne: 

- Aplikacja utrzymana w surowej, typowej dla tarkowa stylistyce. Szaro-brązowe tło, złote przebitki, białe napisy. 


Ekran początkowy: 

- Lista / pole do wpisania nazwy itemu. 

- Dwa przyciski sprzedaj / kup. 

Ekran końcowy dla sprzedaj: 

-lista traderów (zdjęcia i imie), którzy kupują podany przedmiot, wraz z cenami. 

-Ten który ma najlepszą ofertę jest podświetlany / powiększony / wyróżnia się. 

-Możliwość powrotu do ekranu początkowego. 

Ekran końcowy dla kup: 

-lista traderów u których można kupić dany item, wraz z uwzględnieniem potrzebnego poziomu i ceną. 

-Jeśli jeden item można kupić u kilku traderów, podświetla się ten który ma najlepszą cenę. 

-Możliwość powrotu do ekranu początkowego. 
