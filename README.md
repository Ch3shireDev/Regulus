# Regulus

Program do detekcji i poprawiania wadliwych wpisów w bazie danych Stacji Badania Wędrówek Ptaków Uniwersytetu Gdańskiego.

## Motywacja

Uniwersytet Gdański organizuje kilka razy do roku wyjazdy Akcji Bałtyckiej (https://akbalt.ug.edu.pl/), podczas której badacze zbierają dane o wędrówkach ptaków. W ramach tych wyjazdów wypełniane są karty badawcze, które następnie są wpisywane do bazy danych. Proces wpisywania danych jest pracochłonny i wymaga dokładności. Wprowadzanie błędów jest częstym zjawiskiem, co powoduje, że niektóre dane są niepoprawne. Program Regulus ma na celu wykrywanie i poprawianie błędnie wpisanych rekordów.

W ramach programu wyliczane będą średnie i odchylenia standardowe dla parametrów pomiarowych ptaków, m.in. długości skrzydła i rozmiaru ptaka w zależności od gatunków. Następnie wyszukiwane będą wpisy, w których wartości parametrów pomiarowych są odstające. Wpisy z odstającymi wartościami zostaną oznaczone jako błędne i zostaną wyświetlone w specjalnym widoku. Użytkownik będzie mógł je poprawić lub oznaczyć jako poprawne.

## Wymagania funkcjonalne

1. [ ] Stworzyć moduł do pobierania danych z bazy danych Access
2. [ ] Stworzyć moduł do aktualizacji danych w bazie danych Access
3. [ ] Stworzyć moduł do pobierania danych z pliku .csv (do testów)
4. [ ] Stworzyć moduł wyliczający dane statystyczne dla parametrów pomiarowych ptaków
5. [ ] Stworzyć widok główny programu. W widoku powinny się znajdywać:
   - [ ] lista wpisów z bazy danych:
      - [ ] wszystkie
      - [ ] zawierajace błędy
   - [ ] błędne wiersze powinny być oznaczone
   - [ ] powinna być możliwość filtrowania wpisów po gatunku
   - [ ] powinna być możliwość filtrowania wpisów po poprawności
   - [ ] powinna być możliwość oznaczania wpisów jako poprawnych
   - [ ] powinna być możliwość określenia liczby odchyleń standardowych przy których wpis jest uznawany za niepoprawny
   - [ ] powinna być możliwość otworzenia widoku edycji wpisu
6. [ ] Stworzyć widok edycji wpisu. Okno powinno wyświetlać:
   - [ ] wszystkie dane wpisu
   - [ ] powinna być możliwość edycji danych
   - [ ] powinna być możliwość zapisania zmian
   - [ ] powinna być możliwość oznaczenia wpisu jako poprawnego

## Wymagania niefunkcjonalne

1. [ ] Program powinien być napisany w języku C# z wykorzystaniem frameworka .NET 6 lub nowszego oraz biblioteki graficznej WPF.
2. [ ] Program powinien być napisany w architekturze MVVM.
3. [ ] Program powinien być napisany z zastosowaniem zasad SOLID.
4. [ ] Program powinien być napisany w doktrynie TDD.
5. [ ] Program powinien być przygotowany by móc operować na bazie danych Access z tabelami w rozmiarze dwóch milionów rekordów z akceptowalnym czasem przetwarzania.
6. [ ] Czas zapisu wpisu do bazy danych nie powinien przekraczać 1 sekundy.
