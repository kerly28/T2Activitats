### 1. Classes d'equivalència

- **Edat vàlida (dins de l'interval):**  
  Rang: `[0, 120]`  
  **Exemples:** 0, 15, 27, 120

- **Edat per sota del rang vàlid:**  
  Edats: `< 0`  
  **Exemples:** -1, -28, -56, -115

- **Edat per sobre del rang vàlid:**  
  Edats: `> 120`  
  **Exemples:** 121, 250, 600

---

### 2. Casos límit

- **0:**  
  `{ -1, 0, 1 }` (Aquest conjunt prova el límit inferior de l'interval vàlid.)

- **120:**  
  `{ 119, 120, 121 }` (Aquest conjunt prova el límit superior de l'interval vàlid.)

---

### 3. Tests per a cada classe de prova
### Edat vàlida (0 <= age <= 120)

- **[Test 1]**  
  **Entrada:** `age = 0`  
  **Resultat esperat:** `true`

- **[Test 2]**  
  **Entrada:** `age = 54`  
  **Resultat esperat:** `true`

- **[Test 3]**  
  **Entrada:** `age = 120`  
  **Resultat esperat:** `true`

### Edat invàlida (age < 0 o age > 120)

#### Edat < 0:

- **[Test 4]**  
  **Entrada:** `age = -1`  
  **Resultat esperat:** `false`

#### Edat > 120:

- **[Test 5]**  
  **Entrada:** `age = 124`  
  **Resultat esperat:** `false`
