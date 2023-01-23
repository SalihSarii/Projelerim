package com.example.ceviriuygulamasi;

import android.content.ClipData;
import android.content.Context;
import android.content.SharedPreferences;
import android.os.Bundle;

import androidx.fragment.app.Fragment;
import androidx.lifecycle.ViewModelProvider;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.webkit.WebView;
import android.webkit.WebViewClient;

public class fragmentTureng extends Fragment {
    String kelime1="";

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {
// Inflate the layout for this fragment

        //Sonuc Activityde paylaştığım veriye bu şekiilde erişiyorum
        SharedPreferences sp = requireContext().getSharedPreferences("Kelimem", Context.MODE_PRIVATE);
        kelime1 = sp.getString("kelime","");

        String myUrl1= "https://tureng.com/tr/turkce-ingilizce/"+kelime1;

        View v=inflater.inflate(R.layout.fragment_tureng, container, false);
        WebView webView = (WebView) v.findViewById(R.id.webViewTureng);
        webView.getSettings().setJavaScriptEnabled(true);
        webView.setWebViewClient(new WebViewClient());
        webView.loadUrl(myUrl1);
        return v;
    }
}