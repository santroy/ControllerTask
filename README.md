# ControllerTask

**Chcesz zrobić formularz, pozwalający zostawić wiadomość autorowi strony.**

- [x] Utwórz klasę modelu do przechowywania szczegółów wiadomości (właściwości: adres e-mail nadawcy, temat, treść wiadomości). 
- [x] Na stronie /Home/Index zrób formularz, wysyłający te 3 informacje do adresu /Home/SendEmail. 
- [x] Akcja SendEmail kontrolera HomeController powinna być dostępna wyłącznie po odebraniu żądań POST, przyjmować jeden parametr (utworzona przez Ciebie klasa szczegółów wiadomości) oraz zwracać string składający się z poszczególnych składników wiadomości do wysłania. 

# ViewTask

- [x] Bazując na zadaniu z modułu o kontrolerze, zmodyfikuj je tak, aby akcja SendEmail nie zwracała danych string, ale przekazywała obiekt MessageDetails do widoku EmailConfirmation. 
- [x] Widok powinien być silnie typowany. 
- [x] Wszystkie nagłówki strony powinny znajdować się na stronie Layout. 
- [x] Strona Layout powinna zawierać 2 sekcje opcjonalne - TopScripts i BottomScripts, pozwalające na dodanie skryptów na górze lub na dole strony.
