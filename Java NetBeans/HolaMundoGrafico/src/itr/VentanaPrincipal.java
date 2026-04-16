// Define el paquete al que pertenece la clase para organizar
package itr;
import java.awt.Color;
import javax.swing.JFrame;
import javax.swing.JLabel;

/**
 *
 * @author Alexander Romero Ramírez
 */
public class VentanaPrincipal extends JFrame
{
    public JLabel etiqueta, etiqueta2;
    
    public VentanaPrincipal()
    {
        this.setTitle("Para cambiar el título");
        
        this.setSize(400, 400);
        
        this.setResizable(false);
        
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        
        this.getContentPane().setLayout(null);
        this.getContentPane().setBackground(Color.white);
        
        etiqueta = new JLabel("Hola Mundo");
        etiqueta.setBackground(Color.RED);
        etiqueta.setBounds(40,40,80,80);
        etiqueta.setOpaque(true);
        this.getContentPane().add(etiqueta);
        
        etiqueta2 = new JLabel ("Autor: Alexander Romero Ramírez");
        etiqueta2.setBackground(Color.BLUE);
        etiqueta2.setBounds(120,120,200,40);
        etiqueta2.setOpaque(true);
        this.getContentPane().add(etiqueta2);
    }
}