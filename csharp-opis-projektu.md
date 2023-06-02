# Regulus

Program do detekcji i poprawiania wadliwych wpisów w bazie danych Stacji Badania Wędrówek Ptaków Uniwersytetu Gdańskiego.

Baza danych zawiera wpisy o zdarzeniach złapania ptaka danego gatunku w siatkę. Wpisy zawierają informacje o dacie złapania, parametrach skrzydła, rozmiaru, gatunku, płci ptaka oraz numerze obrączki.

W ramach programu wyliczane będą średnie i odchylenia standardowe dla parametrów pomiarowych ptaków, zależne od gatunków. Następnie wyszukiwane będą wpisy, w których wartości parametrów pomiarowych są odstające o ustaloną liczbę odchyleń standardowych. Wpisy z odstającymi wartościami zostaną oznaczone jako błędne i możliwe do wyświetlenia w specjalnym widoku.

## Projekt w C#

1. [x] Moduł do odczytu i zapisu danych z pliku .csv
2. [x] Moduł do wyliczeń danych statystycznych (średnia, odchylenie standardowe) dla parametrów pomiarowych (długość skrzydła, masa, etc.) ptaków
3. [x] Widok główny programu z tabelą z wpisami
4. [x] Oznaczanie wierszy jako błędnych w zależności od podanej liczby odchyleń standardowych
5. [x] Widok edycji wpisu.