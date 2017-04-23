* Program 8 vezir problemini greedy tekni�iyle ��zmektedir
* Vezirin o an bulundu�u sat�r,s�tun ve k��egenlerdeki di�er indisleri
  kapatarak o indisler ba�ka bir vezirin yerle�tirilmesini engellemektedir.
* Bu i�lemler i�in:
  - closeRow --> sat�r� kapat�r
  - closeColumn --> s�tunu kapat�r
  - closeCrossElements --> k��egenleri kapat�r
  metodlar� tan�mlanm��t�r

* Sonraki ad�mda ise findEmptyPlaceForQueen() metodu �al��maktad�r.
  Bu metod herhangi bir vezir yerle�tikten sonra ard�ndan gelen di�eri i�in yer bulmaya �al���r
  Tahtay� dola�arak indiste * veya V(vezir) yoksa bu indisin x ve y koordinat�n� diziye atar(dizi tek boyutlu)
  Metodun sonunda ise dizi return edilmektedir

* Son olarak while d�ng�s� ile findEmptyPlaceForQueen() metodundan gelen dizideki indislere vezirler yerle�tirilir
  ve d�ng� i�inde sat�r,s�tun ve k��egen kapatma i�lemleri, ta ki diziden bo� bir de�er gelene kadar yani
  yeni bir veziri koyacak yer bulamayana kadar uygulan�r

* Ve display metoduyla satranc tahtas�nda vezirlerin dizili�i ekrana bas�l�r

