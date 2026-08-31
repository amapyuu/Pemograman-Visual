# Pemograman-Visual

# 💻 Pertemuan 2: Pengenalan Komponen Visual & Antarmuka Windows Forms

<div align="center">

[![Platform](https://img.shields.io/badge/.NET-Platform-512BD4?style=flat&logo=.NET&logoColor=white)](https://dotnet.microsoft.com/)
[![IDE](https://img.shields.io/badge/Visual%20Studio-IDE-5C2D91?style=flat&logo=visualstudio&logoColor=white)](https://visualstudio.microsoft.com/)
[![Language](https://img.shields.io/badge/Visual%20Basic-Language-blue?style=flat&logo=visual-basic&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/visual-basic/)

</div>

---

## 📖 Ringkasan Materi: Komponen Visual

Pada sesi perkuliahan **Pertemuan 2**, materi utama difokuskan secara mendalam pada pengenalan serta pengaplikasian berbagai **komponen visual (*control*)** di dalam lingkungan kerja Visual Studio. Hal ini bertujuan untuk membangun antarmuka pengguna (*User Interface* / UI) yang interaktif dan fungsional pada aplikasi berbasis *Windows Forms*.

Paradigma **Pemrograman Visual** menawarkan cara kerja yang intuitif dalam merancang tampilan aplikasi. Alih-alih membangun elemen secara manual menggunakan baris kode teks, pengembang dapat menyusun antarmuka menggunakan komponen grafis yang perubahan visualnya dapat dilihat secara langsung seketika itu juga. Jika pemrograman konvensional mengharuskan proses *run* terlebih dahulu untuk melihat perubahan, pemrograman visual memungkinkan perancangan secara *real-time*.

---

## ⚖️ Perbandingan Paradigma Pemrograman

| Parameter Perbandingan | Pemrograman Konvensional | Pemrograman Visual |
| :--- | :--- | :--- |
| **Proses Perancangan UI** | Menulis kode manual untuk mendefinisikan posisi, ukuran, dan bentuk elemen. | Menyusun komponen secara langsung menggunakan teknik visual di atas kanvas. |
| **Umpan Balik Tampilan** | Harus menjalankan program (*run*) terlebih dahulu untuk melihat hasil tata letak. | Perubahan elemen tampak langsung seketika tanpa harus melakukan *compiling* ulang tata letak. |
| **Fokus Pengembangan** | Sintaks murni dan logika program berbasis teks tersembunyi. | Keseimbangan antara estetika visual (*design-time*) dan logika fungsi di baliknya (*code-behind*). |

---

## 🧩 Komponen Dasar Antarmuka (*Controls*)

Dalam mengeksplorasi pembuatan aplikasi Windows Forms, terdapat beberapa elemen esensial yang dipelajari dan wajib dikuasai:

* **Form**: Berperan sebagai jendela utama atau wadah (*container*) fundamental tempat seluruh komponen dan kontrol pendukung lainnya diletakkan.
* **Label**: Berfungsi untuk menyajikan dan menampilkan teks statis kepada pengguna, seperti judul, keterangan, atau instruksi informatif.
* **TextBox**: Komponen interaktif yang bertugas untuk menerima masukan berupa teks (*input*) langsung dari pengguna aplikasi.
* **Button**: Elemen sentuh berbentuk tombol yang dirancang khusus untuk memicu suatu aksi atau *event* tertentu ketika diklik oleh pengguna.

---

## ⚙️ Karakteristik: Properti dan Sistem *Event-Driven*

Setiap komponen visual yang disematkan memiliki karakteristik dan mekanisme interaksi yang kuat:

1. **Pengaturan Properti (*Properties*)**
   Setiap komponen dilengkapi dengan berbagai atribut bawaan—seperti `Name`, `Text`, `Size`, dan `Location`—yang dapat dikonfigurasi dan diatur secara langsung melalui jendela *Properties* di Visual Studio, sehingga pengembang tidak perlu menuliskan sintaks pengaturannya sebagai kode terlebih dahulu.
2. **Sistem Pengelolaan *Event* (*Event Handling*)**
   Selain atribut visual, tiap komponen juga memiliki *event* bawaan (misalnya peristiwa `Click` pada tombol atau `TextChanged` pada kolom teks). Setelah tampilan selesai dirancang, bagian ini dapat disisipi baris kode (*code-behind*) agar komponen tersebut mampu merespons setiap interaksi yang dilakukan oleh pengguna secara dinamis.

---

## 🛠️ Ekosistem Teknologi Pendukung

Seluruh rangkaian proses pembelajaran dan praktik pengembangan perangkat lunak pada mata kuliah ini didukung oleh kombinasi perangkat berikut:
* **Visual Basic**: Bahasa pemrograman utama yang dipilih karena menawarkan struktur sintaks yang ramah pemula dan mudah dipahami.
* **Visual Studio**: Lingkungan Pengembangan Terpadu (*IDE*) andal yang menyediakan fasilitas perancangan visual secara instan.
* **Platform .NET**: Kerangka kerja komprehensif yang menyediakan pustaka dan infrastruktur andal untuk mengeksekusi aplikasi desktop.

