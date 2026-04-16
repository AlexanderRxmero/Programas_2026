package com.gifviewer;

import javax.swing.*;
import java.awt.*;

/**
 *
 * @author Alexander Romero Ramírez
 */
public class VentanaGif extends JFrame
{
    // JLabel que actuará como nuestro 'PictureBox'
    private JLabel lblGif;
    
    public VentanaGif()
    {
        setTitle("GIF Animado - Método por Código");
        setSize(600, 500);
        setDefaultCloseOperation(EXIT_ON_CLOSE);
        setLocationRelativeTo(null); // centrar en pantalla
        construirInterfaz();
    }
    
    private void construirInterfaz()
    {
        setLayout(new BorderLayout());
        
        //  Crear el JLabel que mostrará el GIF
        lblGif = new JLabel();
        lblGif.setHorizontalAlignment (SwingConstants.CENTER);
        lblGif.setBackground(new Color(30, 30, 30));
        lblGif.setOpaque(true);
        
        // Cargar el GIF desde la carpeta de recursos
        // getClass().getResource() busca dentro del classpath del proyecto
        java.net.URL urlGif = getClass().getResource("/imagenes/animacion.gif");
        
        if (urlGif != null)
        {
            // Crear el ImageIcon con la URL del recurso
            ImageIcon iconGif = new ImageIcon(urlGif);
            lblGif.setIcon(iconGif);
        }
        
        else
        {
            // Si no se encuentra el GIF, mostrar un mensaje de error
            lblGif.setText("Error: no se encontró animación.gif");
            lblGif.setForeground(Color.RED);
        }
        add(lblGif, BorderLayout.CENTER);
    }
    
    public static void main(String[] args)
    {
        // Siempre lanzar Swing desde el Event Dispatch Thread (EDT)
        SwingUtilities.invokeLater(() -> new VentanaGif().setVisible(true));
        
        System.out.println("Nombre: Alexander Romero Ramírez");
    }
}