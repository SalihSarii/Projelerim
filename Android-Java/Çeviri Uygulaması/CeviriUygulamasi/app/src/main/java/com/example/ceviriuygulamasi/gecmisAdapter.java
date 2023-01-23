package com.example.ceviriuygulamasi;

import android.content.Context;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.ArrayAdapter;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.annotation.Nullable;

import java.util.Arrays;

public class gecmisAdapter extends ArrayAdapter<String> {
    private String[] kelimeler;
    private String[] tarihler;
    private Context context;
    private TextView kelime;
    private TextView tariht;

    public gecmisAdapter(String[] kelimeler,String[] tarihler,Context context){
        super(context,R.layout.gecmis_item,kelimeler);
        this.kelimeler=kelimeler;
        this.tarihler=tarihler;
        this.context=context;
    }

    @NonNull
    @Override
    public View getView(int position, @Nullable View convertView, @NonNull ViewGroup parent) {
        View view = LayoutInflater.from(context).inflate(R.layout.gecmis_item,null);
        if(view != null){
            kelime=(TextView) view.findViewById(R.id.arananKelime);
            tariht = (TextView) view.findViewById(R.id.kelimeTarih);

            kelime.setText(kelimeler[position]);
            tariht.setText(tarihler[position]);
        }
        return view;
    }

}
