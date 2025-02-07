namespace API_contieneNombre.Services
{
    public class ContieneNombreCode : IContieneNombreCode
    { 

        public bool ContieneNombre(string[] info, string nombre)
        {
            int filas = info.Length;
            int columnas = info[0].Length;
            int tamanio = nombre.Length;

            // se revisa horizontalmente
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j <= columnas - tamanio; j++)
                {
                    if (info[i].Substring(j, tamanio) == nombre)
                    {
                        return true;
                    }
                }
            }

            // se revisa verticalmente
            for (int i = 0; i < columnas; i++)
            {
                for (int j = 0; j <= filas - tamanio; j++)
                {
                    string vertical = "";
                    for (int k = 0; k < tamanio; k++)
                    {
                        vertical += info[j + k][i];
                    }
                    if (vertical == nombre)
                    {
                        return true;
                    }
                }
            }

            // Diagonal
            for (int i = 0; i <= filas - tamanio; i++)
            {
                for (int j = 0; j <= columnas - tamanio; j++)
                {
                    string diagonal = "";
                    for (int k = 0; k < tamanio; k++)
                    {
                        diagonal += info[i + k][j + k];
                    }
                    if (diagonal == nombre)
                    {
                        return true;
                    }
                }
            }
            //  Diagonal 
            for (int i = tamanio - 1; i < filas; i++)
            {
                for (int j = 0; j <= columnas - tamanio; j++)
                {
                    string diagonal = "";
                    for (int k = 0; k < tamanio; k++)
                    {
                        diagonal += info[i - k][j + k];
                    }
                    if (diagonal == nombre)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
