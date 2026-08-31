# 💻 Repositori Praktikum Pemrograman Visual

<div align="center">

[![Platform](https://img.shields.io/badge/.NET-Platform-512BD4?style=flat&logo=.NET&logoColor=white)](https://dotnet.microsoft.com/)
[![IDE](https://img.shields.io/badge/Visual%20Studio-IDE-5C2D91?style=flat&logo=visualstudio&logoColor=white)](https://visualstudio.microsoft.com/)
[![Language](https://img.shields.io/badge/Visual%20Basic-Language-blue?style=flat&logo=visual-basic&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/visual-basic/)

</div>

---

## 📌 Pertemuan 1 - Pengenalan Pemrograman Visual

### 📖 Ringkasan Materi: Konsep Dasar Pemrograman Visual
Pada sesi perkuliahan Pertemuan 1, materi difokuskan pada pengenalan konsep fundamental mengenai apa itu pemrograman visual dan bagaimana perbedaannya dengan pemrograman konvensional berbasis teks.

Pemrograman Visual adalah cara membuat tampilan UI (User Interface) suatu aplikasi bukan dengan mengetikkan baris kode secara manual, melainkan menggunakan komponen-komponen visual grafis yang perubahan wujud dan tata letaknya tampak secara langsung saat itu juga (real-time).

Jika pemrograman biasa memerlukan proses kompilasi atau run terlebih dahulu untuk melihat hasil perubahan tampilan, maka pemrograman visual tidak memerlukannya. Pengembang dapat mendesain aplikasi secara interaktif menggunakan berbagai komponen yang tersedia (seperti Button, TextBox, Label, dan lain-lain). Sesudah tampilan visual selesai dibuat, tahap berikutnya adalah menuliskan kode (code-behind) agar masing-masing komponen dapat berfungsi secara aktif ketika berinteraksi dengan pengguna.


---

### ⚖️ Perbandingan Paradigma Pemrograman

| Parameter Perbandingan | Pemrograman Konvensional | Pemrograman Visual |
| :--- | :--- | :--- |
| **Cara Membuat UI** | Harus menulis kode murni untuk mengatur posisi, ukuran, dan bentuk elemen. | Cukup menyusun dan merancang komponen secara langsung di atas kanvas kerja. |
| **Umpan Balik Tampilan** | Wajib menjalankan program (*run*) terlebih dahulu untuk melihat hasil akhirnya. | Perubahan tampilan langsung terlihat saat itu juga tanpa proses *compile* ulang. |
| **Fokus Utama** | Lebih condong ke sintaks teks dan logika program di balik layar. | Menggabungkan keindahan tata letak visual dengan logika fungsi di baliknya. |

---

### 🛠️ Teknologi yang Digunakan
Dalam seluruh sesi praktikum mata kuliah ini, kita menggunakan beberapa perangkat pendukung utama:
* **Visual Basic**: Bahasa pemrograman pilihan yang struktur kodenya ramah bagi pemula dan sangat mudah dipahami.
* **Visual Studio**: Tempat kerja utama (*IDE*) yang menyediakan fitur lengkap untuk mendesain tampilan secara visual maupun menulis kode.
* **Platform .NET**: Kerangka kerja di balik layar yang menyiapkan berbagai fasilitas agar aplikasi desktop kita bisa berjalan dengan lancar.

---
---

## 📌 Pertemuan 2 - Komponen Visual & Antarmuka Windows Forms

### 📖 Ringkasan Materi: Mengenal Komponen Visual
Pada sesi perkuliahan Pertemuan 2, materi utama difokuskan secara mendalam pada pengenalan serta pengaplikasian berbagai komponen visual (control) di dalam lingkungan kerja Visual Studio. Hal ini bertujuan untuk membangun antarmuka pengguna (User Interface / UI) yang interaktif dan fungsional pada aplikasi berbasis Windows Forms.

Paradigma Pemrograman Visual menawarkan cara kerja yang intuitif dalam merancang tampilan aplikasi. Alih-alih membangun elemen secara manual menggunakan baris kode teks, pengembang dapat menyusun antarmuka menggunakan komponen grafis yang perubahan visualnya dapat dilihat secara langsung seketika itu juga.

---

### 🧩 Komponen Dasar Antarmuka (*Controls*)
Dalam membuat aplikasi berbasis Windows Forms, ada beberapa komponen penting yang wajib kita kenal dan kuasai fungsinya:
* **Form**: Jendela utama atau wadah tempat kita menaruh seluruh komponen lainnya.
* **Label**: Komponen simpel yang tugasnya menampilkan teks atau informasi statis kepada pengguna (misalnya judul atau petunjuk).
* **TextBox**: Kotak interaktif tempat pengguna bisa mengetik atau memasukkan data ke dalam aplikasi.
* **Button**: Tombol yang bisa diklik oleh pengguna untuk memicu suatu aksi tertentu dalam aplikasi.

---

### ⚙️ Mengenal Properti dan Sistem *Event-Driven*
Setiap komponen visual yang kita pasang di form punya dua hal penting yang harus dipahami:

1. **Properti (`Properties`)**  
   Setiap komponen sudah dibekali atribut bawaan seperti `Name` (nama objek), `Text` (tulisan yang tampil), `Size` (ukuran), dan `Location` (posisi). Kita bisa mengubah-ubah semua ini langsung lewat jendela *Properties* di sebelah kanan Visual Studio tanpa harus menulis kode satu pun.

2. **Sistem *Event* (`Event Handling`)**  
   Selain bentuk fisiknya, tiap komponen juga punya *event* atau pemicu kejadian—misalnya peristiwa saat tombol diklik (`Click`) atau saat isi teks di kotak berubah (`TextChanged`). Nah, di bagian sinilah kita nantinya menuliskan baris kode agar aplikasi bisa bereaksi dan merespons setiap interaksi dari pengguna.

---

### 🚀 Panduan Praktis: Membuat Project Pertama di Visual Studio
Supaya lebih paham cara kerja materi Pertemuan 1 dan 2, berikut adalah langkah-langkah ringkas untuk membuat latihan project Windows Forms pertama:

#### 1. Membuat Project Baru
* Buka **Visual Studio**, lalu pilih **Create a new project**.
* Cari template **Windows Forms App** yang menggunakan bahasa **Visual Basic**, lalu klik **Next**.
* Beri nama project (contoh: `Pertemuan2-Komponen-visual`) lalu klik **Create**.

#### 2. Mengenal Area Kerja
* **Form Designer**: Kanvas tempat Anda mendesain tampilan aplikasi secara visual.
* **Toolbox**: Daftar komponen (`Button`, `Label`, `TextBox`) yang bisa ditarik (*drag-and-drop*) ke Form.
* **Jendela Properties**: Panel untuk mengubah pengaturan nama, teks, warna, dan ukuran komponen.

#### 3. Contoh Interaksi Sederhana
* Buat desain *Form* dengan menambahkan beberapa komponen dari *Toolbox*:
  * Tiga buah **TextBox** dengan properti *Name*: `txtNama`, `txtNIM`, dan `txtKOM`
  * Tiga buah **Button** (Tombol Tampilkan,Hapus,Keluar)
* Klik dua kali pada *Button* tersebut untuk membuka editor kode (*code-behind*), lalu masukkan baris kode berikut:

  ```vb
  MessageBox.Show("Guten Morgen" & vbCrLf &
                      "Nama  :" & txtNama.Text & vbCrLf &
                      "NIM   :" & txtNIM.Text & vbCrLf &
                      "KOM   :" & txtKOM.Text
         )
         
  txtKOM.Clear()
  txtNama.Clear()
  txtNIM.Clear()