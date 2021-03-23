# MyApps
there are the begin of my little projects made only by me.
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;

public class TelaInicial extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_tela_inicial);
    }
    public void Logar(View v){
        EditText user = (EditText) findViewById(R.id.editText);
        EditText senha = (EditText) findViewById(R.id.editText2);
        String usuario = user.getText().toString();
        String password = senha.getText().toString();
    }

}
