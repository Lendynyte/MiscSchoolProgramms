
import java.math.RoundingMode;
import java.text.NumberFormat;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
/**
 *
 * @author Dominik Pauli
 * @version 0.0.3
 */
public class mainClass {
   
    
    /**
     * This method rounds number to set decimal digits
     * @param cislo number to shorten
     * @param pocetMist number of decimal digits
     * @return shortened number
     */   
  /*  public static double zaokrouhliCislo(double cislo,  int pocetMist){
        NumberFormat format = NumberFormat.getInstance();
        format.setRoundingMode(RoundingMode.DOWN);
        format.setMaximumFractionDigits(10);
        return Double.parseDouble(format.format(cislo));
    }   */
    
    /**
     * This method shortens number but does not round it
     * @param num number to shorten
     * @param numOfSpaces sdecimal spaces to shorten to
     * @return 
     */
    public static double zkratCislo(double num, int numOfSpaces){
        String numberString = Double.toString(num);
        int indexOfDecimal = numberString.indexOf('.');
        num = new Double(numberString.substring(0, indexOfDecimal + numOfSpaces));
        return num; 
    }    
    
    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Windows look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">

        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Windows".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException | InstantiationException | IllegalAccessException | javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Kalkulacka.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>
        
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            @Override
            public void run() {
                new Kalkulacka().setVisible(true);
            }
        });
    }
}
