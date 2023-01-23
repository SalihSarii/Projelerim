package com.example.ceviriuygulamasi;

import android.content.Context;
import android.content.SharedPreferences;
import android.os.Bundle;

import androidx.fragment.app.Fragment;

import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.webkit.WebView;
import android.webkit.WebViewClient;


public class fragmentGoogle extends Fragment {

    String kelime2="";

    @Override
    public View onCreateView(LayoutInflater inflater, ViewGroup container,
                             Bundle savedInstanceState) {

        SharedPreferences sp = requireContext().getSharedPreferences("Kelimem", Context.MODE_PRIVATE);
        kelime2 = sp.getString("kelime","");

        String myUrl2= "https://translate.google.com/?sl=en&tl=tr&text="+kelime2+"&op=translate";

        View v=inflater.inflate(R.layout.fragment_google, container, false);
        WebView webView = (WebView) v.findViewById(R.id.webViewGoogle);
        webView.getSettings().setJavaScriptEnabled(true);
        webView.setWebViewClient(new WebViewClient());
        webView.loadUrl(myUrl2);
        // Inflate the layout for this fragment
        return v;
    }
}