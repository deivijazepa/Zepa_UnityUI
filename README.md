# Tēla veidotājs (Character Creator – Unity projekts)

Moderns **2D tēla veidotājs**, izstrādāts ar Unity, kas ļauj lietotājam interaktīvi veidot un pielāgot savu tēlu reāllaikā.

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

### Ievades sistēma
- Teksta lauki (vārds, vecums)
- Nolaižamais saraksts (klase)
- Dinamiska datu attēlošana

---

### Tēla priekšskatījums
- Sprite maiņa reāllaikā
- Slāņota sistēma:
  - Galva (Head)
  - Aksesuāri (Accessory)
  - Bruņas (Armor)

---

### Pielāgošanas sistēma
- Toggle izvēles (Hats / Accessories / Armor)
- 3 varianti katrai kategorijai
- Pogu sistēma izvēlei

---

## Rezultāta attēlošana

- Dinamiski atjaunots teksts:
  - **Vārds:** ...
  - **Vecums:** ...
  - **Klase:** ...

---

## Izvēlēto elementu panelis

- Tiek attēlots izvēlēto elementu kopsavilkums:
  - **Cepure:** ...
  - **Aksesuārs:** ...
  - **Bruņas:** ...

---

### Slīdņi

- **Augstums (Height)**
- **Platums (Width)**

---

## Projekta struktūra

```
Assets/
├── Scenes/
│   └── CharacterCreator.unity
├── Scripts/
│   ├── CharacterSelector.cs
│   ├── CustomizationOptions.cs
│   ├── CustomizationSelection.cs
│   └── CustomizationToggles.cs
├── Sprites/
│   ├── Head_*.png
│   ├── Accessory_*.png
│   └── Armor_*.png
├── UI/
└── TextMesh Pro/
```

---

## Izmantotās tehnoloģijas

- Unity 6
- TextMeshPro
- C#
- UI (Canvas sistēma)
- Notikumu vadīta loģika (Event-driven)

---

## Darbības princips

1. Lietotājs ievada vārdu un vecumu
2. Izvēlas tēla klasi
3. Aktivizē kategorijas ar toggle (cepures, aksesuāri, bruņas)
4. Izvēlas konkrētus elementus (pogas)
5. Tēla attēls mainās uzreiz
6. Atjaunojas izvēlēto elementu saraksts

---

## Galvenie skripti

### `CharacterSelector.cs`
Atbild par:
- ievades laukiem
- dropdown izvēli
- rezultāta teksta atjaunošanu

---

### `CustomizationToggles.cs`
Atbild par:
- paneļu parādīšanu/paslēpšanu
- toggle loģiku

---

### `CustomizationOptions.cs`
Atbild par:
- pogu klikšķiem
- sprite maiņu
- izvēlēto elementu tekstu

---

### `CustomizationSelection.cs`
Atbild par:
- izvēlēto datu saglabāšanu
- loģikas koordinēšanu

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
- Drag & Drop sistēma
- Skaņas efekti
- Responsīvs dizains

---

## Priekšskatījums

*(šeit screenshot no projekta)*

---

## Autors

**Deivija Zepa**

---

## Statuss

Pamatfunkcionalitāte izstrādāta  

Iespējami uzlabojumi un dizaina pilnveide  

---

## Piezīmes

Šis projekts izstrādāts mācību nolūkos, koncentrējoties uz:

- UI dizainu
- modulāru programmēšanu
- interaktīvu lietotāja pieredzi

---

