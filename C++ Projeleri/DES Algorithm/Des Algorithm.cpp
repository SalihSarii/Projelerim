#include <iostream>
#include <string>
#include <algorithm>
#include<iterator>
#include <cmath>

using namespace std;
//Main Fonk. En Altta

// Left-Shift(sola kaydirma) operasyonu yapmak icin gerekli fonksiyon
string solaKaydir(string anahtarParcasi, int tekrar) {
	string kaymisAnahtarParcasi = "";
	for (int t = 0; t < tekrar; t++) {
		for (int i = 1; i < 28; i++) {
			kaymisAnahtarParcasi += anahtarParcasi[i];
		}
		kaymisAnahtarParcasi += anahtarParcasi[0];
		anahtarParcasi = kaymisAnahtarParcasi;
		kaymisAnahtarParcasi = "";
	}

	return anahtarParcasi;
}

string Xor(string a, string b) {
	string sonuc = "";
	int uzunluk = b.size();
	for (int i = 0; i < uzunluk; i++) {
		if (a[i] != b[i]) {
			sonuc += "1";
		}
		else {
			sonuc += "0";
		}
	}
	return sonuc;
}
// Decimal olan sayiyi binary'e ceviriyor
string decimalToBinary(int decimal) {
	string binary;
	while (decimal != 0) {
		//sayinin 2'ye göre modu aliniyor. 0 ise binary 0 degilse binary 1 ekleniyor
		binary = (decimal % 2 == 0 ? "0" : "1") + binary;
		decimal = decimal / 2;
	}
	while (binary.length() < 4) {
		binary = "0" + binary;
	}
	return binary;
}

int BinaryToDecimal(string binary)
{
	int decimal = 0;
	int sayac = 0;
	int boyut = binary.length();
	for (int i = boyut - 1; i >= 0; i--)
	{
		if (binary[i] == '1') {
			decimal += pow(2, sayac);
		}
		sayac++;
	}
	return decimal;
}


void anahtarUret(string anahtar, string* tumAnahtarlar) {
	//Birinci Permutasyon Tablosu
	int  pc_1[56] = {
			  57   ,49 ,   41  , 33    ,25,    17   ,9,
			   1   ,58    ,50   ,42    ,34    ,26   ,18,
			  10   , 2    ,59   ,51    ,43    ,35   ,27,
			  19   ,11    , 3   ,60    ,52    ,44   ,36,
			  63   ,55    ,47   ,39    ,31    ,23   ,15,
			   7   ,62    ,54   ,46    ,38    ,30   ,22,
			  14   , 6    ,61   ,53    ,45    ,37   ,29,
			  21   ,13    , 5   ,28    ,20    ,12   ,4
	};

	//Ikinci Permutasyon Tablosu
	int pc_2[48] = {
				 14    ,17   ,11    ,24    , 1   , 5,
				  3    ,28   ,15    , 6    ,21   ,10,
				 23    ,19   ,12    , 4    ,26   , 8,
				 16    , 7   ,27    ,20    ,13   , 2,
				 41    ,52   ,31    ,37    ,47   ,55,
				 30    ,40   ,51    ,45    ,33   ,48,
				 44    ,49   ,39    ,56    ,34   ,53,
				 46    ,42   ,50    ,36    ,29   ,32
	};
	string permute_Anahtar = "";

	// PC_1 tablosu ile permutasyon islemi yapiliyor
	for (int i = 0; i < 56; i++) {
		permute_Anahtar += anahtar[pc_1[i] - 1];
	}

	//56 Bitlik anahtar c0,d0 olarak ikiye ayriliyor. c0=>sol d0=>sag
	string c0 = permute_Anahtar.substr(0, 28);
	string d0 = permute_Anahtar.substr(28, 28);

	//Her asama icin gerekli olacak anahtarlar uretilmeye baslandi.
	// 1,2 ve 9. asamalarda bir sol kaydirma
	//diger asamalar icin ise 2 sol kaydirma yapilacak	
	for (int i = 0; i < 16; i++) {

		if (i == 0 || i == 1 || i == 8) {
			if (i != 0) {
				c0 = solaKaydir(c0, 1);
				d0 = solaKaydir(d0, 1);
			}
			tumAnahtarlar[i] = c0 + d0;
		}
		else {
			c0 = solaKaydir(c0, 2);
			d0 = solaKaydir(d0, 2);

			tumAnahtarlar[i] = c0 + d0;
		}
	}

	//Gerekli olan 48 bitlik anahtarlar icin son bir permütasyon islemi yapýlýyor.
	permute_Anahtar = "";
	for (int i = 0; i < 16; i++) {
		for (int j = 0; j < 48; j++) {
			permute_Anahtar += tumAnahtarlar[i][pc_2[j] - 1];
		}
		tumAnahtarlar[i] = permute_Anahtar;
		permute_Anahtar = "";
		string a = "";
	}

}


string algDes(string mesaj, string* tumAnahtarlar) {
	//Ilk permutasyon tablosu
	int iP[] = {
			58,50,42,34,26,18,10,2,
			60,52,44,36,28,20,12,4,
			62,54,46,38,30,22,14,6,
			64,56,48,40,32,24,16,8,
			57,49,41,33,25,17, 9,1,
			59,51,43,35,27,19,11,3,
			61,53,45,37,29,21,13,5,
			63,55,47,39,31,23,15,7
	};

	//Mesaj geniþletme tablosu
	int expansion_table[48] = {
	32,1,2,3,4,5,4,5,
	6,7,8,9,8,9,10,11,
	12,13,12,13,14,15,16,17,
	16,17,18,19,20,21,20,21,
	22,23,24,25,24,25,26,27,
	28,29,28,29,30,31,32,1
	};


	int sub_tablolari[8][4][16] =
	{ {
		14,4,13,1,2,15,11,8,3,10,6,12,5,9,0,7,
		0,15,7,4,14,2,13,1,10,6,12,11,9,5,3,8,
		4,1,14,8,13,6,2,11,15,12,9,7,3,10,5,0,
		15,12,8,2,4,9,1,7,5,11,3,14,10,0,6,13
	},
	{
		15,1,8,14,6,11,3,4,9,7,2,13,12,0,5,10,
		3,13,4,7,15,2,8,14,12,0,1,10,6,9,11,5,
		0,14,7,11,10,4,13,1,5,8,12,6,9,3,2,15,
		13,8,10,1,3,15,4,2,11,6,7,12,0,5,14,9
	},
	{
		10,0,9,14,6,3,15,5,1,13,12,7,11,4,2,8,
		13,7,0,9,3,4,6,10,2,8,5,14,12,11,15,1,
		13,6,4,9,8,15,3,0,11,1,2,12,5,10,14,7,
		1,10,13,0,6,9,8,7,4,15,14,3,11,5,2,12
	},
	{
		7,13,14,3,0,6,9,10,1,2,8,5,11,12,4,15,
		13,8,11,5,6,15,0,3,4,7,2,12,1,10,14,9,
		10,6,9,0,12,11,7,13,15,1,3,14,5,2,8,4,
		3,15,0,6,10,1,13,8,9,4,5,11,12,7,2,14
	},
	{
		2,12,4,1,7,10,11,6,8,5,3,15,13,0,14,9,
		14,11,2,12,4,7,13,1,5,0,15,10,3,9,8,6,
		4,2,1,11,10,13,7,8,15,9,12,5,6,3,0,14,
		11,8,12,7,1,14,2,13,6,15,0,9,10,4,5,3
	},
	{
		12,1,10,15,9,2,6,8,0,13,3,4,14,7,5,11,
		10,15,4,2,7,12,9,5,6,1,13,14,0,11,3,8,
		9,14,15,5,2,8,12,3,7,0,4,10,1,13,11,6,
		4,3,2,12,9,5,15,10,11,14,1,7,6,0,8,13
	},
	{
		4,11,2,14,15,0,8,13,3,12,9,7,5,10,6,1,
		13,0,11,7,4,9,1,10,14,3,5,12,2,15,8,6,
		1,4,11,13,12,3,7,14,10,15,6,8,0,5,9,2,
		6,11,13,8,1,4,10,7,9,5,0,15,14,2,3,12
	},
	{
		13,2,8,4,6,15,11,1,10,9,3,14,5,0,12,7,
		1,15,13,8,10,3,7,4,12,5,6,11,0,14,9,2,
		7,11,4,1,9,12,14,2,0,6,10,13,15,3,5,8,
		2,1,14,7,4,10,8,13,15,12,9,0,3,5,6,11
	} };

	// S-Box sonrasi permutasyon tablosu
	int permTablosu[32] = {
	16,7,20,21,29,12,28,17,
	1,15,23,26,5,18,31,10,
	2,8,24,14,32,27,3,9,
	19,13,30,6,22,11,4,25
	};
	// The inverse permutation table
	int iP_1[64] = {
	40,8,48,16,56,24,64,32,
	39,7,47,15,55,23,63,31,
	38,6,46,14,54,22,62,30,
	37,5,45,13,53,21,61,29,
	36,4,44,12,52,20,60,28,
	35,3,43,11,51,19,59,27,
	34,2,42,10,50,18,58,26,
	33,1,41,9,49,17,57,25
	};

	string permuteMesaj = "";
	//Mesaj permute iP tablosuyla permute ediliyor.
	for (int i = 0; i < 64; i++) {
		permuteMesaj += mesaj[iP[i] - 1];
	}
	cout <<"permuteMesaj:"<< permuteMesaj << endl;

	//mesaj sag ve sol olarak ikiye bölünüyor
	string sol = permuteMesaj.substr(0, 32);
	string sag = permuteMesaj.substr(32, 32);
	cout << "sag:"<<sag << endl;
	//16 asama basliyor
	for (int i = 0; i < 16; i++) {

		string sagGenisletilmis = "";
		//Mesaj 32 bitten 48 bite cikariliyor
		for (int j = 0; j < 48; j++) {
			sagGenisletilmis += sag[expansion_table[j] - 1];
		}
		cout << "sagGenisletilmis:"<<sagGenisletilmis << "  " << i+1 << ".Round" << endl;
		//Mesaj ile anahtar xor iþlemine sokulur.
		string xorluMetin = Xor(tumAnahtarlar[i], sagGenisletilmis);
		cout << "xorluMetin:"<<xorluMetin << "  " << i+1 << ".Round" << endl;		
		string sBoxSonuc = "";
		//sBox Kismi
		for (int j = 0; j < 8; j++) {

			//sBox'ýn ilk biti ile son biti alýnýp birleþtiriliyor.
			string satir1 = xorluMetin.substr(j * 6, 1) + xorluMetin.substr(j * 6 + 5, 1);
			int satir = BinaryToDecimal(satir1);
			string sutun1 = xorluMetin.substr(j * 6 + 1, 4);
			int sutun = BinaryToDecimal(sutun1);
			int tabloSonucu = sub_tablolari[j][satir][sutun];
			sBoxSonuc += decimalToBinary(tabloSonucu);
		}
		cout << "sBoxSonuc:"<<sBoxSonuc << "  " << i+1 << ".Round" << endl;
		//32 bitlik sifreli mesaj tekrar permutasyon islemine giriyor
		string permuteMesaj2 = "";
		for (int j = 0; j < 32; j++) {
			permuteMesaj2 += sBoxSonuc[permTablosu[i] - 1];
		}
		cout << "permuteMesaj2:"<<permuteMesaj2 << "  " << i+1 << ".Round" << endl;
		//Mesajýn sol kýsmý ile islemlerden gecmis sag kismi XOR islemine giriyor
		xorluMetin = Xor(permuteMesaj2, sol);
		cout << "xorluMetin:"<<xorluMetin << "  " << i+1 << ".Round" << endl;
		//son asamada sol ve sag bir kez daha yer degistirdigi icin 
		sol = xorluMetin;
		if (i < 15) {
			string temp = sag;
			sag = xorluMetin;
			sol = temp;
		}
	cout<<i+1<<".Round Bitimi-------------------------------------------------------------"<<endl;
	}

	/*//Son asamadan sonra sag ve sol bloklar bir kez daha yer degistiriliyor.
	string temp = sag;
	sag = sol;
	sol = temp;
	*/
	//Sag ve sol parcalar birlestiriliyor ve en basta yapilan permutasyonun tersi ile isleme sokuluyor
	string sonMesaj = sol + sag;
	cout << "sonMesaj:"<<sonMesaj <<endl;
	string sifreliMesaj = ""; //ciphertext

	for (int i = 0; i < 64; i++) {
		sifreliMesaj += sonMesaj[iP_1[i] - 1];
	}
	cout << "sifreliMesaj:"<<sifreliMesaj<< endl;
	//Elde edilen sifreli mesaj dönülüyor.
	return sifreliMesaj;
}

//////////////////////////////////
//////////////////////////////////

int main() {

	//Ilk Anahtar - Anahtar uzunlugu 64 bittir.
	string anahtar = "1010101010111011000010010001100000100111001101101100110011011101";
	string tumAnahtarlar[16];
	//DES Algoritmasi icin gerekli olan 16 anahtar hazirlanmasi icin gerekli olan fonksiyona gidilir.
	anahtarUret(anahtar, tumAnahtarlar);
	//Plain Text
	string mesaj = "1010101111001101111001101010101111001101000100110010010100110110";
	
	cout<<"Sifreleme Islemi----------------------------------------------------------"<<endl<<endl<<endl;	
	string sifreliMesaj = algDes(mesaj, tumAnahtarlar);
	cout<<endl<<endl;
	
	string tumAnahtarlarTers[16];
	//Desifreleme islemi icin anahtarlar tam tersi sýrada sýralanarak veriliyor.	
	int j = 0;
	for (int i = 15; i >= 0; i--) {
		tumAnahtarlarTers[j] = tumAnahtarlar[i];
		j++;
	}
	cout<<"Desifreleme Islemi----------------------------------------------------------"<<endl;
	string desifreliMesaj = algDes(sifreliMesaj, tumAnahtarlarTers);

	if (desifreliMesaj == mesaj) {
		cout << "Algoritma basarili";
	}

	return 0;
}
