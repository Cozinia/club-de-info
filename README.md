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

---

## Clase (exemplu: Chitara)

Gândindu-ne la o **chitară**: știm că are corzi, o cutie de rezonanță, o culoare, un model. În program, clasa este „rețeta” care spune ce are o chitară și ce poate face. Din această rețetă poți crea chitare concrete: una roșie cu 6 corzi, alta neagră cu 12 corzi etc.

- **Ce este o clasă**  
  Este șablonul (rețeta) unui tip de obiect. Descrie ce date are obiectul și ce acțiuni poate face. Din clasă faci obiecte reale: ex. clasa `Chitara`, obiecte `chitaraMea`, `chitaraTa`.

- **Atribute**  
  Sunt datele pe care le are fiecare obiect. La o chitară: câte corzi are, ce culoare are, cum se numește modelul. Fiecare chitară creată în program are propriile valori pentru aceste lucruri (ex: `nrCorzi`, `culoare`, `numeModel`).

- **Public**  
  Înseamnă că oricine poate folosi acel lucru. Ex: o metodă `canta()` publică – oricine poate apela `chitaraMea.canta()`. E ca un buton pe care îl poate apăsa oricine.

- **Private**  
  Înseamnă că doar interiorul clasei „vede” acel lucru. Din afară nu poți schimba direct, de exemplu, cum sunt setate corzile; doar metodele chitarei pot folosi sau modifica acele date. Te ajută să păstrezi lucrurile în ordine și să eviți modificări greșite.

- **Constructor default**  
  E constructorul fără parametri. Creezi o chitară fără să îi spui nimic: `Chitara c;`. Chitara există, dar cu valori implicite (sau neinițializate). Dacă nu scrii niciun constructor, compilatorul îți dă unul astfel automat.

- **Constructor cu parametri**  
  Creezi obiectul și îi dai de la început ce ai nevoie. Ex: `Chitara c(6, "rosu", "Fender");` – o chitară cu 6 corzi, roșie, model Fender. Constructorul primește aceste valori și le pune în atribute (nr corzi, culoare, nume model).

- **Getter**  
  E o metodă care **îți dă** o informație despre obiect, fără să schimbe nimic. Ex: „câte corzi are chitara?” – `getNrCorzi()` returnează 6. E ca să întrebi și să primești răspuns.

- **Setter**  
  E o metodă care **schimbă** o informație din obiect. Ex: „vreau să fie roșie” – `setCuloare("rosu")` pune culoarea la roșu. Poți verifica în setter (ex: să nu accepte un număr negativ de corzi) înainte să schimbi efectiv atributul.

- **De ce getter și setter**  
  Păstrezi atributele `private` (ascunse), iar lumea le folosește doar prin getter (să citească) și setter (să modifice). Așa controlezi cum se citesc și cum se schimbă datele, cu termeni simpli: „întrebi” cu getter, „comanzi” cu setter.



---

## Desktop Dev - WinForms (QR WiFi)

În folderul `Desktop/WinForms/QR_WiFi` este o aplicație desktop făcută cu Windows Forms care generează un cod QR pentru conectare la WiFi.

### Ce face aplicația

- Primește de la utilizator:
  - `SSID` (numele rețelei) din `tbSsid`
  - `Password` din `tbPass`
- La click pe butonul `Generate`, construiește textul standard WiFi:
  - `WIFI:T:WPA;S:{ssid};P:{pass};;`
- Textul este transformat în cod QR cu biblioteca `QRCoder`.
- QR-ul este:
  - afișat în aplicație în `PictureBox` (`pbQrCode`)
  - salvat ca fișier `.png` pe disk.

### Cum funcționează pas cu pas

- **1. Luare text din TextBox**
  - `string ssid = tbSsid.Text;`
  - `string pass = tbPass.Text;`
- **2. Construire payload WiFi**
  - Se face un string în formatul înțeles de telefoane pentru conectare rapidă la WiFi prin scanare.
- **3. Generare QR**
  - `QRCodeGenerator` creează datele QR.
  - `BitmapByteQRCode` face un bitmap (imagine) din acele date.
- **4. Validare**
  - Se verifică dacă `ssid` sau `pass` sunt goale/albe.
  - În implementarea curentă condiția este cu `||` (OR), adică merge pe ramura de succes dacă cel puțin una dintre valori este completată.
  - Dacă validarea trece, status-ul devine verde (`Success!`), altfel roșu (`SSID or pass empty!`).
- **5. Afișare imagine în aplicație**
  - `pbQrCode.Image = new Bitmap(bitmap, pbQrCode.Size);`
  - Asta redimensionează QR-ul la dimensiunea zonei `PictureBox`, ca să fie vizibil direct în UI.
- **6. Salvare PNG**
  - `bitmap.Save($"../../../{ssid}_qr.png", ImageFormat.Png);`
  - Se salvează imaginea cu numele rețelei, de exemplu `MyWifi_qr.png`.

### Ce înseamnă `../../../` și de ce îl folosim

- `../` înseamnă „urcă un folder mai sus”.
- `../../../` înseamnă „urcă 3 foldere”.
- În WinForms, la rulare, calea curentă este de obicei în `bin/Debug/...` sau `bin/Release/...`.
- Dacă ai salva direct fără `../../../`, fișierul ar ajunge în acel folder de build.
- Cu `../../../`, urci din folderul de build spre folderul proiectului, ca PNG-ul să fie salvat într-un loc mai ușor de găsit în proiect.

### Elemente UI folosite în proiect

- `TextBox`: `tbSsid`, `tbPass` pentru input.
- `Button`: `btnGenerate` pentru pornirea generării.
- `Label`: `lblStatus` pentru feedback de succes/eroare.
- `PictureBox`: `pbQrCode` pentru preview-ul imaginii QR în fereastră.

---

## Clean code - naming si conventii

### Ce face `string.IsNullOrWhiteSpace(ssid)`

- Verifica daca stringul `ssid` este:
  - `null` (nu are valoare),
  - gol (`""`),
  - sau contine doar spatii/tab-uri/newline.
- Practic este o validare rapida de input.
- E mai sigur decat sa verifici doar `ssid == ""`, pentru ca acopera mai multe cazuri reale.

### Ce face `lblStatus.ForeColor = Color.Red;`

- `lblStatus` este un control de tip `Label`.
- `ForeColor` este culoarea textului afisat de acel label.
- `Color.Red` coloreaza textul in rosu, de obicei pentru mesaj de eroare.
- In acelasi mod, `Color.Green` sugereaza succes.

### De ce folosim `lblStatus`

- Aplicatia are nevoie de feedback vizual pentru utilizator.
- `lblStatus` este locul unde afisam starea curenta: succes sau eroare.
- Utilizatorul vede imediat ce s-a intamplat dupa click pe buton, fara sa deschida loguri sau consola.

### Logica numelor in WinForms: tip control + rol

In WinForms, de multe ori numele controlului urmeaza modelul:

- prefix de tip control + nume descriptiv al rolului

Exemple din proiect:

- `lblStatus` = `lbl` (Label) + `Status` (ce arata)
- `tbSsid` = `tb` (TextBox) + `Ssid` (ce citeste)
- `btnGenerate` = `btn` (Button) + `Generate` (ce actiune face)
- `pbQrCode` = `pb` (PictureBox) + `QrCode` (ce afiseaza)

Avantaj: cand citesti codul, vezi rapid si tipul controlului, si scopul lui.

### Diferenta intre PascalCase si camelCase

- `PascalCase`:
  - Fiecare cuvant incepe cu litera mare.
  - Exemple: `Form1`, `GenerateQrCode`, `UserName`.
  - Folosit des in C# pentru clase, metode, proprietati.

- `camelCase`:
  - Primul cuvant incepe cu litera mica, urmatoarele cu litera mare.
  - Exemple: `ssidValue`, `userName`, `totalCount`.
  - Folosit des pentru variabile locale si parametri.

### Alte stiluri de scriere nume

- `snake_case`:
  - Cuvintele sunt separate cu `_`, toate litere mici.
  - Exemplu: `user_name`.
  - Folosit des in C/C++ (in unele proiecte), Python, C.

- `UPPER_SNAKE_CASE`:
  - Litere mari + `_`.
  - Exemplu: `MAX_BUFFER_SIZE`.
  - Folosit de obicei pentru constante/macrouri.

- `kebab-case`:
  - Cuvintele separate cu `-`.
  - Exemplu: `user-name`.
  - Nu este valid pentru identificatori in C/C++/C# (minusul e operator).
  - E folosit mai mult in URL-uri, fisiere, CSS.

### Ce este Altman si ce nu este

- `Altman style` este un stil de formatare pentru acolade.
- Exemplu Altman:

`if (x > 0)`
`{`
`    // cod`
`}`

- Deci:
  - `PascalCase` / `camelCase` / `snake_case` = stiluri de nume
  - `Altman` / `K&R` / `Allman` = stiluri de pozitionare a acoladelor

### Recomandare simpla pentru inceput

- Alege o conventie si ramai consecvent.
- Pentru C#:
  - clase/metode/proprietati: `PascalCase`
  - variabile locale/parametri: `camelCase`
  - controale WinForms: prefix tip + nume descriptiv (`tbName`, `btnSave`, `lblError`)

