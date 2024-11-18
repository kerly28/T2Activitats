```public static int AppliedDiscount(int age);```

### 1. Classes d'equivalència

- **Nens (0-12 anys):**  
  **Descompte:** 50%  
  Rang: `[0, 12]`  
  **Exemples:** 1, 3, 12

- **Joves (13-17 anys):**  
  **Descompte:** 25%  
  Rang: `[13, 17]`  
  **Exemples:** 13, 15, 17

- **Majors (>= 65 anys):**  
  **Descompte:** 30%  
  Rang: `[65, ∞]`  
  **Exemples:** 66, 72, 84

- **Adults (18-64 anys):**  
  **Descompte:** 0%  
  Rang: `[18, 64]`  
  **Exemples:** 18, 42, 64

---

### 2. Tests per validar la correcta aplicació del descompte

#### [Tests per nens (0-12 anys)]

- **[Test 1]**  
  **Entrada:** `age = 0`  
  **Resultat esperat:** `50%`

- **[Test 2]**  
  **Entrada:** `age = 7`  
  **Resultat esperat:** `50%`

- **[Test 3]**  
  **Entrada:** `age = 12`  
  **Resultat esperat:** `50%`

#### [Tests per joves (13-17 anys)]

- **[Test 4]**  
  **Entrada:** `age = 13`  
  **Resultat esperat:** `25%`

- **[Test 5]**  
  **Entrada:** `age = 15`  
  **Resultat esperat:** `25%`

- **[Test 6]**  
  **Entrada:** `age = 17`  
  **Resultat esperat:** `25%`

#### [Tests per majors (>= 65 anys)]

- **[Test 7]**  
  **Entrada:** `age = 65`  
  **Resultat esperat:** `30%`

- **[Test 8]**  
  **Entrada:** `age = 72`  
  **Resultat esperat:** `30%`

#### [Tests per adults (18-64 anys)]

- **[Test 9]**  
  **Entrada:** `age = 18`  
  **Resultat esperat:** `0%`

- **[Test 10]**  
  **Entrada:** `age = 42`  
  **Resultat esperat:** `0%`

- **[Test 11]**  
  **Entrada:** `age = 64`  
  **Resultat esperat:** `0%`

---

### 3. Casos límit per als descomptes

#### Nens (0-12 anys):

- **0:** `{ -1, 0, 1 }`
- **12:** `{ 11, 12, 13 }`

#### Joves (13-17 anys):

- **13:** `{ 12, 13, 14 }`
- **17:** `{ 16, 17, 18 }`

#### Majors (>= 65 anys):

- **65:** `{ 64, 65, 66 }`

#### Adults (18-64 anys):

- **18:** `{ 17, 18, 19 }`
- **64:** `{ 63, 64, 65 }`

Són casos límits perquè aquests conjunts mostra les fronteres de les clases d'equivalència per a cada rang d'edat.
