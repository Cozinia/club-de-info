## C++ for dummies


## Directive de preprocesor și namespace uri

- **`#include <iostream>`**  
  - `#include` este o **directivă de preprocesor**.  
  - Ea spune compilatorului: „înainte să compilezi programul, adaugă aici conținutul fișierului `iostream`”.  
  - `iostream` conține definițiile pentru `cout`, `cin` și altele legate de input/output la consolă.

- **`using namespace std;`**  
  - `std` este un **namespace** în care C++ a pus multe lucruri standard (cum ar fi `cout`, `cin`, `string` etc.).  
  - Când scrii `using namespace std;`, îi spui compilatorului că poți folosi direct `cout` în loc de `std::cout`, `cin` în loc de `std::cin` etc.  
  - Este util la exemple mici, ca acestea, ca să nu scrii tot timpul `std::`.

---

## `1-afisare.cpp` – afișare text la consolă

- **Scop**: să vezi cum se afișează text pe ecran în C++.  
- **Ce face programul**:
  - Include `iostream` și folosește `using namespace std;`.
  - În `main`, folosește `cout` pentru a scrie un mesaj în consolă: de exemplu, „Buna seara Bucuresti!”.
  - `<<` se citește „trimite către”: `cout << "text"` = „trimite textul către ecran”.
  - `endl` mută cursorul pe rândul următor (echivalent cu „enter”).

---

## `2-tipuri-de-date.cpp` – tipuri de date de bază

- **Scop**: să vezi câteva tipuri de date de bază în C++.  
- **Tipuri folosite**:
  - `int a = 10;` – număr întreg (fără virgulă).
  - `float b = 10.5;` – număr real (cu virgulă).
  - `char c = 'a';` – un singur caracter.
  - `bool d = true;` – valoare logică (poate fi `true` sau `false`).
- **Ce ar putea urma**:
  - Poți afișa valorile lor cu `cout` sau să le folosești în calcule și condiții.

---

## `3-citire.cpp` – citire de la tastatură

- **Scop**: să înveți cum citești informații de la utilizator.  
- **Ce face programul**:
  - Declară un șir de caractere: `char nume[64];` – adică o zonă de memorie unde se va ține numele.
  - Afișează un mesaj: `cout << "Introduceti numele: ";` ca să ceară utilizatorului să scrie ceva.
  - Folosește `cin >> nume;` pentru a **citi** ce tastează utilizatorul până la primul spațiu.
  - Apoi afișează un mesaj personalizat: `Ce faci <nume>?`.

---

## `4-if.cpp` – structura de decizie `if`

- **Scop**: să înveți cum iei decizii în program, în funcție de o condiție.  
- **Ce face programul**:
  - Declară două variabile întregi: `int a = 10;` și `int b = 15;`.
  - Verifică `if (a > b)`:
    - Dacă `a` este mai mare decât `b`, afișează „a e mai mare”.
    - Altfel (`else`), afișează „b e mai mare”.

---

## `5-while.cpp` – buclă cu număr necunoscut de pași

- **Scop**: să înveți cum repeți o acțiune cât timp o condiție este adevărată.  
- **Ce face programul**:
  - Are două variabile: `a = 10`, `b = 15`.
  - `while (a < b)` înseamnă: „cât timp `a` este mai mic decât `b`, repetă ce este în acolade”.
  - În interiorul buclei:
    - Afișează `a e mai mare` (mesaj de exemplu).
    - Mărește `a` cu 1: `a++;`.
  - Când `a` nu mai este mai mic decât `b`, bucla se oprește și se afișează cât a ajuns `a`.
- **Idee principală**: `while` repetă o bucată de cod până când condiția devine falsă. Nu știm dinainte exact de câte ori se va repeta, depinde de date.

---

## `6-for.cpp` – buclă cu număr cunoscut de pași

- **Scop**: să înveți o formă de buclă folosită des când știi câte repetări vrei.  
- **Ce face programul**:
  - Folosește un `for` clasic: `for (int i = 0; i < 10; i++)`.
    - `int i = 0;` – pornește contorul `i` de la 0.
    - `i < 10;` – bucla continuă cât timp `i` este mai mic decât 10.
    - `i++` – la fiecare pas, `i` crește cu 1.
  - În interiorul buclei, afișează valoarea lui `i` la fiecare pas.
- **Idee principală**: `for` este ideal pentru „repetă de X ori”, când știi de la început câte repetări vrei.

---

## `7-vectori.cpp` – vectori

- **Scop**: să înveți cum lucrezi cu o colecție de valori de același tip.  
- **Ce face programul**:
  - Declară și inițializează un vector de 10 întregi:  
    `int vector[10] = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};`
  - Folosește un `for` pentru a parcurge fiecare element:
    - `vector[i]` reprezintă elementul de pe poziția `i`.
    - Pentru `i` de la 0 la 9, se afișează toate valorile.
- **Idee principală**: un vector este ca o stradă, iar casele de pe stradă sunt valorile vectorului , pentru a ajule la o casă trebuie să le accesezi prin indice (`[i]`).


