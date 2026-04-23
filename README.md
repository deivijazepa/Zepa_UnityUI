# Tēla veidotājs (Character Creator – Unity UI projekts)

Šis projekts ir izstrādāts Unity vidē, izmantojot dažādus UI elementus, lai izveidotu interaktīvu tēla veidošanas sistēmu.

---

## Kā palaist .exe versiju

1. Atvērt Build/Windows/
2. Palaist Zepa_UnityUI.exe

---

## Pārskats

Šī lietotne ļauj:

- Ievadīt **vārdu** un **vecumu**
- Izvēlēties **tēla klasi**
- Pielāgot tēlu:
  - Cepures (Hats)
  - Aksesuāri (Accessories)
  - Bruņas (Armor)
- Regulēt tēla:
  - Augstumu (Height)
  - Platumu (Width)
- Redzēt izmaiņas **uzreiz priekšskatījumā**
- Apskatīt izvēlēto elementu kopsavilkumu

---

## Funkcionalitāte

### Navigācija
- Sākuma izvēlne (Main Menu)
- Poga **Start** atver Character Creator ainu
- Poga **Exit** aizver aplikāciju
- Poga **Back** atgriežas uz galveno izvēlni
- Character Creator ainā:
  - Back poga atgriež uz sākuma izvēlni
  - Pogām pievienoti skaņas efekti

---

### Tēla izvēle
- Izmantojot dropdown, iespējams izvēlēties vairākus tēlus
- Mainās:
  - tēla attēls
  - apraksts (Scroll View)
  - klase

---

### Datu ievade
- Name laukā iespējams ievadīt tikai burtus
- Age laukā iespējams ievadīt tikai skaitļus
- Rezultātā tiek attēlots teksts ar ievadītajiem datiem

---

### Customization sistēma
Ir izveidotas vairākas kategorijas:
- Hats
- Accessories
- Armor

Katru kategoriju var:
- ieslēgt/izslēgt ar toggle
- izvēlēties konkrētu elementu ar pogām

Selected Items laukā tiek attēlota izvēle:
- Hat
- Accessory
- Armor

**Piezīme:**  
Cepures izvēle maina tēla vizuālo izskatu, savukārt aksesuāri un bruņas tiek attēloti izvēlēto elementu sarakstā.

---

### Drag & Drop
- Iespējams pārvilkt apģērba elementus uz tēla
- Pēc “drop” tiek nomainīts tēla apģērbs (overlay)
- Demonstrēts drag & drop princips UI vidē

---

### Reset funkcija
- Poga “Reset” noņem izvēlēto apģērbu
- Pieejama tikai Forest Ranger tēlam

---

### Skaņas efekti
- Pogām pievienota klikšķa skaņa
- Uzlabota lietotāja pieredze

---

### Tēla izmēru maiņa
- Izmantojot sliderus:
  - Height → maina augstumu
  - Width → maina platumu

---

### Scroll View
- Attēlo izvēlētā tēla aprakstu
- Mainās atkarībā no izvēles

---

## Projekta struktūra

```
Assets/
├── Scenes/
│ ├── MainMenu.unity
│ └── CharacterCreator.unity
├── Scripts/
│ ├── CharacterSelector.cs
│ ├── CustomizationOptions.cs
│ ├── CustomizationSelection.cs
│ ├── CustomizationToggles.cs
│ ├── DraggableItem.cs
│ ├── DropZone.cs
│ ├── UIButtonSound.cs
│ └── MainMenuUI.cs
├── Sprites/
│   ├── Head_.png
│   ├── Accessory_.png
│   └── Armor_.png
├── UI/
└── TextMesh Pro/
```

---

## Izmantotās tehnoloģijas

- Unity 6
- TextMeshPro
- C#
- UI (Canvas sistēma)
- Event-driven programmēšana

---

## Versiju kontrole
Projekts tiek pārvaldīts ar Git un glabāts GitHub repozitorijā.

---

## Darbības princips

1. Lietotājs ievada vārdu un vecumu
2. Izvēlas tēla klasi (dropdown)
3. Aktivizē kategorijas ar toggle (cepures, aksesuāri, bruņas)
4. Izvēlas konkrētus elementus (pogas vai drag & drop)
5. Tēla attēls un informācija atjaunojas
6. Selected Items panelī tiek attēlota izvēle

---

## Galvenie skripti

### `CharacterSelector.cs`
- Apstrādā ievades laukus
- Kontrolē dropdown izvēli
- Atjauno rezultāta tekstu

---

### `CustomizationToggles.cs`
- Pārvalda kategoriju paneļus
- Nodrošina toggle loģiku

---

### `CustomizationOptions.cs`
- Apstrādā pogu klikšķus
- Maina tēla attēlu
- Atjauno Selected Items

---

### `CustomizationSelection.cs`
- Koordinē izvēlēto datu loģiku

---

### `DraggableItem.cs` / `DropZone.cs`
- Nodrošina drag & drop funkcionalitāti

---

### `UIButtonSound.cs`
- Atskaņo pogu klikšķu skaņas

---

### `MainMenuUI.cs`
- Pārvalda navigāciju starp ainām

---

## UI izkārtojums

- **Kreisais panelis**
  - Ievades lauki
  - Klases izvēle
  - Rezultāta teksts

- **Centrs**
  - Tēla priekšskatījums

- **Labais panelis**
  - Apraksts
  - Toggle izvēles
  - Pielāgošanas pogas
  - Izvēlēto elementu saraksts
  - Slīdņi

---

## Nākotnes uzlabojumi

- Saglabāt / ielādēt tēlu
- Animācijas
- Vairāk pielāgošanas opciju
- Paplašināti skaņas efekti
- Responsīvs dizains

---

## Autors

**Deivija Zepa**

---

## Statuss

Pamatfunkcionalitāte izstrādāta  

Projekts pilnībā funkcionāls  

Iespējami uzlabojumi un dizaina pilnveide  

---

## Piezīmes

Šis projekts izstrādāts mācību nolūkos, koncentrējoties uz:

- UI dizainu
- modulāru programmēšanu
- interaktīvu lietotāja pieredzi

---

