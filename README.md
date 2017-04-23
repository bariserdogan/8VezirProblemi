* Program 8 vezir problemini greedy tekniðiyle çözmektedir
* Vezirin o an bulunduðu satýr,sütun ve köþegenlerdeki diðer indisleri
  kapatarak o indisler baþka bir vezirin yerleþtirilmesini engellemektedir.
* Bu iþlemler için:
  - closeRow --> satýrý kapatýr
  - closeColumn --> sütunu kapatýr
  - closeCrossElements --> köþegenleri kapatýr
  metodlarý tanýmlanmýþtýr

* Sonraki adýmda ise findEmptyPlaceForQueen() metodu çalýþmaktadýr.
  Bu metod herhangi bir vezir yerleþtikten sonra ardýndan gelen diðeri için yer bulmaya çalýþýr
  Tahtayý dolaþarak indiste * veya V(vezir) yoksa bu indisin x ve y koordinatýný diziye atar(dizi tek boyutlu)
  Metodun sonunda ise dizi return edilmektedir

* Son olarak while döngüsü ile findEmptyPlaceForQueen() metodundan gelen dizideki indislere vezirler yerleþtirilir
  ve döngü içinde satýr,sütun ve köþegen kapatma iþlemleri, ta ki diziden boþ bir deðer gelene kadar yani
  yeni bir veziri koyacak yer bulamayana kadar uygulanýr

* Ve display metoduyla satranc tahtasýnda vezirlerin diziliþi ekrana basýlýr

