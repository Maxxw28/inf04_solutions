package com.example.inf04_2024_czerwiec;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

import java.util.Dictionary;
import java.util.HashMap;
import java.util.Map;
import java.util.Random;

public class MainActivity extends AppCompatActivity {
    private int wynikGryInt = 0;
    private TextView wynik;
    private TextView wynikGry;
    private ImageView img1, img2, img3, img4, img5;
    private ImageView[] obrazkiKostek;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });

        Button rzut = findViewById(R.id.button);
        Button reset = findViewById(R.id.button2);

        wynik = findViewById(R.id.textView2);
        wynikGry = findViewById(R.id.textView3);

        //images
        img1 = findViewById(R.id.imageView);
        img2 = findViewById(R.id.imageView2);
        img3 = findViewById(R.id.imageView3);
        img4 = findViewById(R.id.imageView4);
        img5 = findViewById(R.id.imageView5);

        obrazkiKostek = new ImageView[]{img1, img2, img3, img4, img5};

        rzut.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                int[] tab = Losuj();

                aktualizujObrazkiKostek(tab);

                int suma = obliczSumeDuplikatow(tab);
                //wynik.setText(Integer.toString(suma));

                wynik.setText("Wynik tego losowania: " + suma);

                wynikGryInt += suma;

                wynikGry.setText("Wynik gry: " + String.valueOf(wynikGryInt));

            }
        });
        reset.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                wynikGryInt = 0;
                wynik.setText("Wynik tego losowania: 0");
                wynikGry.setText("Wynik gry: 0");
                resetujObrazkiKostek();
            }
        });

    }
    public int[] Losuj() {
        int[] tempTab = new int[5];
        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            int diceValue = random.nextInt(6) + 1;
            tempTab[i] = diceValue;
        }
        return tempTab;
    }
    //opisana dokładnie funckja do nauki ale nie najlepsza praktyka podczas egzaminu
    //Fragment kodu od obliczania sumy identyczny jak w aplikacji konsolowej w C#
    public static int obliczSumeDuplikatow(int[] tab) {
        // Odpowiednik Dictionary<int, int> w Javie to HashMap<Integer, Integer>
        // Używamy interfejsu Map po lewej stronie dla dobrej praktyki
        Map<Integer, Integer> counts = new HashMap<>();

        // Iteracja przez tablicę - odpowiednik foreach
        for (int number : tab) {
            // Sprawdzenie, czy klucz (liczba) już istnieje w mapie
            if (counts.containsKey(number)) {
                // Jeśli tak, pobierz obecną liczbę wystąpień i zwiększ ją o 1
                counts.put(number, counts.get(number) + 1);
            } else {
                // Jeśli nie, dodaj liczbę do mapy z liczbą wystąpień 1
                counts.put(number, 1);
            }
            /* Alternatywny, bardziej zwięzły sposób (od Javy 8):
               counts.put(number, counts.getOrDefault(number, 0) + 1);
            */
        }

        int totalSum = 0;
        // Iteracja przez pary klucz-wartość w mapie (odpowiednik foreach po Dictionary)
        // entrySet() zwraca zbiór wpisów (Map.Entry)
        for (Map.Entry<Integer, Integer> entry : counts.entrySet()) {
            int number = entry.getKey();   // Pobranie klucza
            int count = entry.getValue(); // Pobranie wartości

            // Sprawdzenie warunku - czy liczba wystąpień jest większa niż 1
            if (count > 1) {
                totalSum += number * count; // Dodanie do sumy iloczynu liczby i jej wystąpień
            }
        }

        return totalSum; // Zwrócenie obliczonej sumy
    }
    private void resetujObrazkiKostek() {
        int questionMarkResourceId = R.drawable.question;
        for (ImageView img : obrazkiKostek) {
            img.setImageResource(questionMarkResourceId);
        }
    }
    private void aktualizujObrazkiKostek(int[] tablicaWartosci) {
        if (tablicaWartosci.length != obrazkiKostek.length) {
            System.err.println("Błąd: Niezgodna liczba wartości i obrazków!");
            return;
        }
        for (int i = 0; i < obrazkiKostek.length; i++) {
            int resourceId = getDrawableIdForDiceValue(tablicaWartosci[i]);
            obrazkiKostek[i].setImageResource(resourceId);
        }
    }
    private int getDrawableIdForDiceValue(int value) {
        switch (value) {
            case 1: return R.drawable.dice1;
            case 2: return R.drawable.dice2;
            case 3: return R.drawable.dice3;
            case 4: return R.drawable.dice4;
            case 5: return R.drawable.dice5;
            case 6: return R.drawable.dice6;
            default: return R.drawable.question;
        }
    }

}