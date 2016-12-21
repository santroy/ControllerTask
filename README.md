# ControllerTask

**Chcesz zrobić formularz, pozwalający zostawić wiadomość autorowi strony.**

- [x] Utwórz klasę modelu do przechowywania szczegółów wiadomości (właściwości: adres e-mail nadawcy, temat, treść wiadomości). 
- [x] Na stronie /Home/Index zrób formularz, wysyłający te 3 informacje do adresu /Home/SendEmail. 
- [x] Akcja SendEmail kontrolera HomeController powinna być dostępna wyłącznie po odebraniu żądań POST, przyjmować jeden parametr (utworzona przez Ciebie klasa szczegółów wiadomości) oraz zwracać string składający się z poszczególnych składników wiadomości do wysłania. 
