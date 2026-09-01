<div align="center">

# ୨୧ Repositori Praktikum Pemrograman Visual ୨୧

<p>
<img src="https://img.shields.io/badge/Pemrograman%20Visual-Visual%20Basic%20.NET-0078D7?style=for-the-badge&logo=dotnet&logoColor=white" width="370">
<img src="https://img.shields.io/badge/IDE-Visual%20Studio-5C2D91?style=for-the-badge&logo=visualstudio&logoColor=white" width="200">
<img src="https://img.shields.io/badge/Platform-Windows%20Forms-00A4EF?style=for-the-badge" width="260">
</p>

### ♡ Dokumentasi Praktikum Pemrograman Visual ♡

*Visual Basic .NET • Windows Forms • GUI • Event-Driven Programming*

</div>

---


## ♡ Daftar Isi

- ♡ [Pertemuan 1 — Pengenalan Pemrograman Visual](#-pengenalan-pemrograman-visual-)
- ♡ [Pertemuan 2 — Komponen Visual & Antarmuka Windows Forms](#-komponen-visual--antarmuka-windows-forms-)
- ♡ [Pertemuan 3 — Operator, Struktur Pengendalian & Validasi Input](#-operator-struktur-pengendalian--validasi-input-)

---

# ୨୧ PERTEMUAN 1

## ✦ Pengenalan Pemrograman Visual ✦

---

## ♡ Ringkasan Materi

Pertemuan pertama membahas konsep fundamental **Pemrograman Visual** serta perbedaannya dengan pemrograman konvensional berbasis teks.

**Pemrograman Visual** merupakan metode pengembangan perangkat lunak yang memungkinkan programmer membuat antarmuka pengguna (**User Interface / UI**) menggunakan komponen grafis secara visual.

Pada pendekatan ini, programmer dapat menyusun komponen seperti `Button`, `Label`, `TextBox`, dan komponen lainnya menggunakan metode **drag-and-drop** pada sebuah designer.

Perubahan posisi, ukuran, warna, maupun tata letak komponen dapat dilihat secara langsung pada **Form Designer**, sehingga proses perancangan antarmuka menjadi lebih intuitif.

Setelah tampilan selesai dirancang, programmer kemudian menambahkan **kode program (code-behind)** untuk menentukan bagaimana setiap komponen merespons interaksi pengguna.

---

## ✦ Konsep Dasar Pemrograman Visual ✦

Pemrograman Visual menggabungkan dua bagian utama:

```text
┌──────────────────────────────┐
│        VISUAL DESIGN         │
│                              │
│ Form + Button + TextBox      │
│ Label + PictureBox + dll.    │
└──────────────┬───────────────┘
               ↓
┌──────────────────────────────┐
│         CODE-BEHIND          │
│                              │
│ Event + Method + Logic       │
└──────────────┬───────────────┘
               ↓
┌──────────────────────────────┐
│      APLIKASI INTERAKTIF     │
└──────────────────────────────┘
```

### ♡ Visual Designer

Digunakan untuk mengatur tampilan aplikasi secara visual.

Contohnya:

- ♡ Menambahkan Button
- ♡ Mengatur ukuran Form
- ♡ Mengubah warna komponen
- ♡ Mengatur posisi kontrol
- ♡ Mengubah jenis dan ukuran font

### ♡ Code-Behind

Digunakan untuk menentukan perilaku dari komponen visual.

Contohnya:

```vb
Private Sub btnInput_Click(
    sender As Object,
    e As EventArgs
) Handles btnInput.Click

    MessageBox.Show("Tombol diklik!")

End Sub
```

Ketika pengguna menekan tombol `btnInput`, event `Click` akan dijalankan dan program menampilkan pesan.

---

## ✦ Perbandingan Paradigma Pemrograman ✦

| Parameter | Pemrograman Konvensional | Pemrograman Visual |
|:---|:---|:---|
| Pembuatan UI | Menulis kode secara manual | Drag-and-drop |
| Tampilan | Dilihat setelah program dijalankan | Dapat dilihat melalui Designer |
| Fokus | Sintaks dan logika | UI dan logika |
| Interaksi | Dikendalikan melalui kode | Berbasis Event |
| Perancangan | Lebih banyak dilakukan melalui kode | Dibantu Visual Designer |
| Pengembangan | Cenderung lebih manual | Lebih intuitif |

---

## ✦ Event-Driven Programming ✦

Pemrograman Visual menggunakan konsep **Event-Driven Programming**, yaitu program bekerja berdasarkan kejadian atau tindakan yang dilakukan pengguna.

Contoh:

```text
Pengguna klik Button
        ↓
Event Click terjadi
        ↓
btnInput_Click dipanggil
        ↓
Kode dijalankan
        ↓
Hasil ditampilkan
```

### ♡ Event yang Umum Digunakan

| Event | Deskripsi |
|:---|:---|
| `Click` | Terjadi ketika pengguna mengklik kontrol |
| `Load` | Terjadi ketika Form pertama kali dimuat |
| `TextChanged` | Terjadi ketika isi TextBox mengalami perubahan |
| `KeyPress` | Terjadi ketika pengguna menekan tombol keyboard |
| `MouseEnter` | Terjadi ketika pointer mouse masuk ke area kontrol |
| `MouseLeave` | Terjadi ketika pointer mouse meninggalkan kontrol |

---

## ✦ Konsep Object, Property, Method & Event ✦

Dalam Windows Forms, setiap komponen dapat dianggap sebagai sebuah object.

Contohnya:

```text
TextBox
   │
   ├── Property → Text, Name, Size
   ├── Method   → Clear(), Focus()
   └── Event    → TextChanged, KeyPress
```

Konsep ini menjadi dasar penting untuk praktikum berikutnya.

# ୨୧ PERTEMUAN 2

## ✦ Komponen Visual & Antarmuka Windows Forms ✦

---

## ♡ Ringkasan Materi

Pertemuan kedua membahas pembuatan antarmuka aplikasi menggunakan **Windows Forms** serta penggunaan berbagai kontrol visual yang tersedia di Visual Studio.

Komponen visual dapat ditambahkan ke Form melalui **Toolbox** menggunakan metode **drag-and-drop**.

---

## ✦ Windows Forms ✦

Windows Forms merupakan framework UI yang digunakan untuk membuat aplikasi desktop berbasis Windows.

Dalam Windows Forms terdapat:

- ♡ `Form` sebagai container utama.
- ♡ `Label` untuk menampilkan teks.
- ♡ `TextBox` untuk input.
- ♡ `Button` untuk menjalankan perintah.
- ♡ `PictureBox` untuk menampilkan gambar.

---

## ✦ Komponen Dasar Antarmuka ✦

### ♡ Form

Form adalah wadah utama aplikasi tempat seluruh kontrol diletakkan.

Contoh:

```text
┌─────────────────────────────────┐
│        DATA MAHASISWA           │
│                                 │
│ Nama : [____________________]   │
│ NIM  : [____________________]   │
│ KOM  : [____________________]   │
│                                 │
│ [Tampilkan] [Hapus] [Keluar]   │
└─────────────────────────────────┘
```

### ♡ Label

Label digunakan untuk menampilkan teks atau informasi statis kepada pengguna.

Contoh:

```text
Nama :
NIM  :
KOM  :
```

### ♡ TextBox

TextBox digunakan sebagai tempat pengguna memasukkan data.

Contoh penamaan:

```text
txtNama
txtNIM
txtKOM
```

### ♡ Button

Button digunakan sebagai pemicu suatu perintah.

Contoh:

```text
btnTampilkan
btnHapus
btnKeluar
```

### ♡ PictureBox

PictureBox digunakan untuk menampilkan gambar pada Form.

Contoh:

```text
picImage
```

---

## ✦ Properties ✦

Properties merupakan atribut yang menentukan karakteristik suatu kontrol.

| Property | Deskripsi |
|:---|:---|
| `Name` | Menentukan nama objek yang digunakan dalam kode |
| `Text` | Menentukan teks yang ditampilkan |
| `Size` | Menentukan ukuran kontrol |
| `Location` | Menentukan posisi kontrol |
| `BackColor` | Mengatur warna latar belakang |
| `ForeColor` | Mengatur warna teks |
| `Font` | Mengatur jenis, ukuran, dan gaya font |
| `Visible` | Menentukan apakah kontrol terlihat |
| `Enabled` | Menentukan apakah kontrol dapat digunakan |

Contoh:

```vb
txtNama.Text = "Budi"
txtNama.BackColor = Color.LightBlue
```

---

## ✦ Method ✦

Method merupakan tindakan atau fungsi yang dapat dilakukan oleh suatu object.

| Method | Deskripsi |
|:---|:---|
| `Clear()` | Menghapus isi kontrol |
| `Focus()` | Memindahkan fokus ke kontrol |
| `Show()` | Menampilkan object/form |
| `Hide()` | Menyembunyikan object/form |

Contoh:

```vb
txtNama.Clear()
txtNama.Focus()
```

---

## ✦ Event Handling ✦

Event digunakan untuk menjalankan kode ketika suatu kejadian terjadi.

Contoh:

```vb
Private Sub btnTampilkan_Click(
    sender As Object,
    e As EventArgs
) Handles btnTampilkan.Click

    MessageBox.Show("Hello World!")

End Sub
```

Kode tersebut akan dijalankan ketika pengguna mengklik tombol `btnTampilkan`.

---

## ✦ Membuat Project Pertama ✦

1. Buka Visual Studio.
2. Pilih **Create a new project**.
3. Pilih **Windows Forms App (.NET Framework)**.
4. Pilih bahasa **Visual Basic**.
5. Berikan nama project:

```text
Pertemuan2PemVi
```

6. Klik **Create**.
7. Buka Form Designer.
8. Tambahkan komponen dari Toolbox.
9. Atur Properties.
10. Tulis kode event handler.

---

## ♡ Shortcut Visual Studio

| Shortcut | Fungsi |
|:---:|:---|
| `Ctrl + Alt + X` | Membuka Toolbox |
| `F4` | Membuka Properties Window |
| `F5` | Menjalankan Debugging |
| `Ctrl + S` | Menyimpan project |
| `Ctrl + Z` | Undo |

---

## ✦ Implementasi Program ✦

Tambahkan:

- ♡ 3 Label
- ♡ 3 TextBox
- ♡ 3 Button

Gunakan nama:

```text
txtNama
txtNIM
txtKOM
btnTampilkan
btnHapus
btnKeluar
```

### ♡ Tombol Tampilkan

```vb
Private Sub btnTampilkan_Click(
    sender As Object,
    e As EventArgs
) Handles btnTampilkan.Click

    MessageBox.Show(
        "Guten Morgen" & vbCrLf &
        "Nama : " & txtNama.Text & vbCrLf &
        "NIM  : " & txtNIM.Text & vbCrLf &
        "KOM  : " & txtKOM.Text,
        "Informasi Data",
        MessageBoxButtons.OK,
        MessageBoxIcon.Information
    )

End Sub
```

### ♡ Tombol Hapus

```vb
Private Sub btnHapus_Click(
    sender As Object,
    e As EventArgs
) Handles btnHapus.Click

    txtNama.Clear()
    txtNIM.Clear()
    txtKOM.Clear()
    txtNama.Focus()

End Sub
```

### ♡ Tombol Keluar

```vb
Private Sub btnKeluar_Click(
    sender As Object,
    e As EventArgs
) Handles btnKeluar.Click

    Dim jawaban As DialogResult

    jawaban = MessageBox.Show(
        "Apakah Anda yakin ingin keluar?",
        "Konfirmasi",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

    If jawaban = DialogResult.Yes Then
        Application.Exit()
    End If

End Sub
```

---

## ✦ Naming Convention ✦

Penamaan kontrol sebaiknya konsisten agar kode mudah dibaca.

| Kontrol | Prefix | Contoh |
|:---|:---:|:---|
| Button | `btn` | `btnInput` |
| TextBox | `txt` | `txtNama` |
| Label | `lbl` | `lblNama` |
| PictureBox | `pic` | `picImage` |
| Form | `frm` | `frmLogin` |

Format event:

```text
[NamaKontrol]_[NamaEvent]
```

Contoh:

```text
btnInput_Click
txtNilai_KeyPress
```

---

## ✦ Penggunaan Asset ✦

Untuk menggunakan gambar dari folder project:

```text
Asset/
├── kelinci.jpg
├── bunny.jpg
└── rabbit.png
```

Atur:

```text
Copy to Output Directory
        ↓
Copy if newer
```

Hal ini memastikan file asset tersedia ketika aplikasi dijalankan.

# ୨୧ PERTEMUAN 3

## ✦ Operator, Struktur Pengendalian & Validasi Input ✦

---

## ♡ Ringkasan Materi

Pertemuan ketiga membahas dasar logika pemrograman yang digunakan untuk membuat aplikasi lebih interaktif dan mampu mengambil keputusan berdasarkan input pengguna.

Materi meliputi:

- ♡ Operator aritmatika
- ♡ Operator penugasan
- ♡ Operator perbandingan
- ♡ Operator logika
- ♡ Ekspresi
- ♡ Increment dan decrement
- ♡ Percabangan `If`
- ♡ `Select Case`
- ♡ Operator ternary
- ♡ Validasi input
- ♡ Konversi data
- ♡ Event `KeyPress`
- ♡ Pemrosesan gambar berdasarkan kondisi

---

## ✦ Tiga Pilar Komponen Visual ✦

### ♡ Property

Atribut atau karakteristik dari kontrol.

```vb
txtNilai.Text
txtNilai.Visible
txtNilai.Enabled
```

### ♡ Method

Tindakan yang dapat dilakukan kontrol.

```vb
txtNilai.Clear()
txtNilai.Focus()
```

### ♡ Event

Kejadian yang dapat memicu kode.

```vb
btnInput_Click
txtNilai_KeyPress
```

---

## ✦ Operator VB.NET ✦

Operator digunakan untuk melakukan operasi terhadap nilai, variabel, maupun ekspresi.

### ♡ Operator Aritmatika

Operator aritmatika digunakan untuk melakukan operasi perhitungan matematika.

| Operator | Nama | Deskripsi | Contoh | Hasil |
|:---:|:---|:---|:---:|---:|
| `+` | Penjumlahan | Menambahkan dua nilai | `10 + 5` | `15` |
| `-` | Pengurangan | Mengurangi nilai pertama dengan nilai kedua | `10 - 5` | `5` |
| `*` | Perkalian | Mengalikan dua nilai | `10 * 5` | `50` |
| `/` | Pembagian | Membagi nilai secara numerik | `10 / 3` | `3.333...` |
| `\` | Pembagian Bulat | Mengambil hasil bilangan bulat | `10 \ 3` | `3` |
| `Mod` | Modulus | Menghasilkan sisa pembagian | `10 Mod 3` | `1` |
| `^` | Pangkat | Menghitung nilai pangkat | `2 ^ 3` | `8` |

### ♡ Contoh

```vb
Dim a As Integer = 10
Dim b As Integer = 3

Dim tambah = a + b
Dim kurang = a - b
Dim kali = a * b
Dim bagi = a / b
Dim bulat = a \ b
Dim sisa = a Mod b
Dim pangkat = a ^ b
```

---

## ✦ Operator Penugasan ✦

Operator penugasan digunakan untuk memberikan atau memperbarui nilai sebuah variabel.

| Operator | Deskripsi | Contoh | Hasil |
|:---:|:---|:---:|:---|
| `=` | Memberikan nilai ke variabel | `x = 10` | `10` |
| `+=` | Menambahkan nilai ke variabel | `x += 5` | `x + 5` |
| `-=` | Mengurangi nilai variabel | `x -= 5` | `x - 5` |
| `*=` | Mengalikan nilai variabel | `x *= 5` | `x × 5` |
| `/=` | Membagi nilai variabel | `x /= 5` | `x ÷ 5` |

### ♡ Contoh

```vb
Dim x As Integer = 10

x += 5
x -= 3
x *= 2
x /= 4
```

---

## ✦ Operator Perbandingan ✦

Operator perbandingan digunakan untuk membandingkan dua nilai.

Hasil dari perbandingan adalah **Boolean**, yaitu `True` atau `False`.

| Operator | Nama | Deskripsi | Contoh |
|:---:|:---|:---|:---:|
| `=` | Sama dengan | Mengecek apakah dua nilai sama | `10 = 10` |
| `<>` | Tidak sama | Mengecek apakah dua nilai berbeda | `10 <> 5` |
| `>` | Lebih besar | Mengecek apakah nilai kiri lebih besar | `10 > 5` |
| `<` | Lebih kecil | Mengecek apakah nilai kiri lebih kecil | `5 < 10` |
| `>=` | Lebih besar/sama | Mengecek nilai lebih besar atau sama | `10 >= 10` |
| `<=` | Lebih kecil/sama | Mengecek nilai lebih kecil atau sama | `5 <= 10` |

### ♡ Contoh

```vb
Dim nilai As Integer = 80

If nilai >= 75 Then
    MessageBox.Show("Lulus")
End If
```

---

## ✦ Operator Logika ✦

Operator logika digunakan untuk menggabungkan atau membalik kondisi Boolean.

### ♡ And

Menghasilkan `True` apabila semua kondisi bernilai `True`.

```vb
If nilai >= 0 And nilai <= 100 Then
    MessageBox.Show("Nilai valid")
End If
```

| A | B | A And B |
|:---:|:---:|:---:|
| True | True | True |
| True | False | False |
| False | True | False |
| False | False | False |

### ♡ AndAlso

`AndAlso` bekerja seperti `And`, tetapi menggunakan **short-circuit evaluation**.

Artinya, jika kondisi pertama sudah `False`, kondisi berikutnya tidak perlu dievaluasi.

```vb
If txtNilai.Text <> "" AndAlso
   Integer.TryParse(txtNilai.Text, nilai) Then

    MessageBox.Show("Input valid")

End If
```

Penggunaan `AndAlso` umumnya lebih efisien dan aman untuk kondisi yang membutuhkan pemeriksaan bertahap.

### ♡ Or

Menghasilkan `True` apabila minimal satu kondisi bernilai `True`.

```vb
If hari = "Sabtu" Or hari = "Minggu" Then
    MessageBox.Show("Hari libur")
End If
```

| A | B | A Or B |
|:---:|:---:|:---:|
| True | True | True |
| True | False | True |
| False | True | True |
| False | False | False |

### ♡ OrElse

`OrElse` bekerja seperti `Or`, tetapi menggunakan **short-circuit evaluation**.

Jika kondisi pertama sudah `True`, kondisi berikutnya tidak perlu dievaluasi.

```vb
If nilai < 0 OrElse nilai > 100 Then
    MessageBox.Show("Nilai tidak valid")
End If
```

### ♡ Not

Not digunakan untuk membalik nilai Boolean.

```vb
Dim aktif As Boolean = True

If Not aktif Then
    MessageBox.Show("Tidak aktif")
End If
```

Hasil:

```text
Not True  → False
Not False → True
```

---

## ✦ Increment & Decrement ✦

Digunakan untuk menambah atau mengurangi nilai variabel secara bertahap.

### ♡ Increment

Menambahkan nilai sebesar satu:

```vb
x += 1
```

### ♡ Decrement

Mengurangi nilai sebesar satu:

```vb
x -= 1
```

### ♡ Contoh

```vb
Dim counter As Integer = 0

counter += 1
counter += 1
counter += 1
```

Hasil akhir:

```text
counter = 3
```

---

## ✦ Ekspresi ✦

Ekspresi merupakan kombinasi antara nilai, variabel, dan operator yang menghasilkan sebuah nilai.

```text
Nilai + Variabel + Operator
```

Contoh:

```vb
Dim a As Integer = 10
Dim b As Integer = 5

Dim hasil As Integer = (a + b) * 2
```

Hasil:

```text
30
```

Urutan operasi matematika tetap perlu diperhatikan. Penggunaan tanda kurung dapat digunakan untuk memperjelas prioritas operasi.

---

## ✦ Struktur Pengendalian ✦

### ♡ If...Then

Digunakan untuk menjalankan kode apabila kondisi bernilai `True`.

```vb
If nilai >= 75 Then
    MessageBox.Show("Lulus")
End If
```

### ♡ If...Then...Else

Digunakan ketika terdapat dua kemungkinan.

```vb
If nilai >= 75 Then
    MessageBox.Show("Lulus")
Else
    MessageBox.Show("Tidak Lulus")
End If
```

### ♡ If...ElseIf...Else

Digunakan untuk menangani beberapa kondisi.

```vb
If nilai >= 85 Then
    grade = "A"

ElseIf nilai >= 75 Then
    grade = "B"

ElseIf nilai >= 65 Then
    grade = "C"

Else
    grade = "D"

End If
```

### ♡ Select Case

Digunakan untuk memilih tindakan berdasarkan satu nilai yang memiliki beberapa kemungkinan.

```vb
Select Case grade

    Case "A"
        MessageBox.Show("Sangat Baik")

    Case "B"
        MessageBox.Show("Baik")

    Case "C"
        MessageBox.Show("Cukup")

    Case Else
        MessageBox.Show("Perlu Perbaikan")

End Select
```

`Select Case` biasanya lebih mudah dibaca dibandingkan banyak `ElseIf` apabila kondisi didasarkan pada satu variabel.

### ♡ Operator Ternary If()

Digunakan untuk membuat percabangan sederhana dalam satu baris.

```vb
Dim status As String

status = If(
    nilai >= 75,
    "Lulus",
    "Tidak Lulus"
)
```

Struktur:

```text
If(kondisi, nilai_jika_true, nilai_jika_false)
```

---

## ✦ Validasi Input ✦

Validasi input digunakan untuk memastikan data yang dimasukkan pengguna sesuai dengan aturan program.

Pada praktikum ini, nilai harus:

- ♡ Berupa angka.
- ♡ Berada pada rentang `0–100`.

Alurnya:

```text
Input pengguna
      ↓
Apakah angka?
   ↓       ↓
 Tidak     Ya
   ↓       ↓
Warning  Cek rentang
            ↓
       0 ≤ nilai ≤ 100
          ↓       ↓
       Tidak      Ya
          ↓       ↓
       Warning   Proses
```

### ♡ Integer.TryParse

`Integer.TryParse()` digunakan untuk mengonversi `String` menjadi `Integer` dengan aman.

Contoh:

```vb
Dim nilai As Integer

If Integer.TryParse(txtNilai.Text, nilai) Then

    MessageBox.Show("Input valid")

Else

    MessageBox.Show("Input harus berupa angka")

End If
```

Keunggulannya adalah program dapat menangani input yang tidak valid tanpa menyebabkan exception konversi yang tidak tertangani.

---

## ✦ Event KeyPress ✦

`KeyPress` dapat digunakan untuk memvalidasi input secara langsung ketika pengguna menekan keyboard.

Contoh:

```vb
Private Sub txtNilai_KeyPress(
    sender As Object,
    e As KeyPressEventArgs
) Handles txtNilai.KeyPress

    If Not Char.IsControl(e.KeyChar) AndAlso
       Not Char.IsDigit(e.KeyChar) Then

        e.Handled = True

    End If

End Sub
```

### ♡ Penjelasan

`Char.IsDigit()` digunakan untuk mengecek apakah karakter merupakan angka.

`Char.IsControl()` digunakan agar karakter kontrol seperti **Backspace** tetap dapat digunakan.

Sedangkan:

```vb
e.Handled = True
```

berfungsi membatalkan input karakter yang tidak diperbolehkan.

---

## ✦ Percabangan Berdasarkan Nilai ✦

Program dapat menggunakan nilai yang dimasukkan pengguna untuk menentukan gambar yang ditampilkan.

| Rentang Nilai | File Gambar |
|:---:|:---|
| `0–50` | `kelinci.jpg` |
| `51–75` | `bunny.jpg` |
| `76–100` | `rabbit.png` |

Kode:

```vb
If nilai <= 50 Then

    picImage.Image = Image.FromFile(
        "Asset\kelinci.jpg"
    )

ElseIf nilai <= 75 Then

    picImage.Image = Image.FromFile(
        "Asset\bunny.jpg"
    )

Else

    picImage.Image = Image.FromFile(
        "Asset\rabbit.png"
    )

End If
```

---

## ✦ Implementasi Program Lengkap ✦

```vb
Public Class Form1

    ' Event Handler: Tombol Input
    Private Sub btnInput_Click(
        sender As Object,
        e As EventArgs
    ) Handles btnInput.Click

        Dim nilai As Integer

        ' Validasi konversi data
        If Not Integer.TryParse(txtNilai.Text, nilai) Then

            MessageBox.Show(
                "Masukkan dalam bentuk angka!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtNilai.Focus()
            Return

        End If

        ' Validasi rentang nilai
        If nilai < 0 OrElse nilai > 100 Then

            MessageBox.Show(
                "Masukkan Nilai 0-100!",
                "Peringatan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            )

            txtNilai.Focus()
            Return

        End If

        ' Menentukan gambar berdasarkan nilai
        If nilai <= 50 Then

            picImage.Image = Image.FromFile(
                "Asset\kelinci.jpg"
            )

        ElseIf nilai <= 75 Then

            picImage.Image = Image.FromFile(
                "Asset\bunny.jpg"
            )

        Else

            picImage.Image = Image.FromFile(
                "Asset\rabbit.png"
            )

        End If

    End Sub


    ' Event Handler: Validasi input keyboard
    Private Sub txtNilai_KeyPress(
        sender As Object,
        e As KeyPressEventArgs
    ) Handles txtNilai.KeyPress

        If Not Char.IsControl(e.KeyChar) AndAlso
           Not Char.IsDigit(e.KeyChar) Then

            e.Handled = True

        End If

    End Sub

End Class
```

---

## ✦ Penjelasan Alur Program ✦

### ♡ 1. Pengguna memasukkan nilai

Input diberikan melalui:

```text
txtNilai
```

### ♡ 2. Validasi keyboard

`KeyPress` membatasi karakter yang dapat dimasukkan.

### ♡ 3. Konversi data

`Integer.TryParse()` memastikan input dapat diproses sebagai angka.

### ♡ 4. Validasi rentang

Program memastikan nilai berada di antara:

```text
0 ≤ nilai ≤ 100
```

### ♡ 5. Percabangan

Program memilih gambar berdasarkan nilai.

### ♡ 6. Visual Rendering

Gambar ditampilkan melalui:

```text
picImage.Image
```