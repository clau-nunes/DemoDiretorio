CriarDireitoriosGlobo();
//CriarArquivo();
var origem = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
var destino = Path.Combine(Environment.CurrentDirectory, "globo", "América do Sul", "Argentina", "argentina.txt");
//MoverArquivo(origem, destino);
CopiarArquivo(origem, destino);

static void CopiarArquivo(string pathOrigem, string pathDestino)
{
    if(!File.Exists(pathOrigem))
    {
        Console.WriteLine("Aquivo de origem não existe");
        return;
    }
        
    
    if(!File.Exists(pathDestino))
    {
        Console.WriteLine("Aquivo já existe na pasta de destino");
        return;
    }
    File.Copy(pathOrigem, pathDestino);

}

static void MoverArquivo(string pathOrigem, string pathDestino)
{
    if(!File.Exists(pathOrigem))
    {
        Console.WriteLine("Aquivo de origem não existe");
        return;
    }
        
    
    if(!File.Exists(pathDestino))
    {
        Console.WriteLine("Aquivo já existe na pasta de destino");
        return;
    }
        
    File.Move(pathOrigem, pathDestino);

}

static void CriarArquivo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
    if(!File.Exists(path))
    {
        using var sw =  File.CreateText(path);
        sw.WriteLine("População: 212,6 milhões (2020)");
        sw.WriteLine("IDH: 0,710");
        sw.WriteLine("Dados atualizados em 2020");
        sw.WriteLine("O orgulho do brasileiro é falar um FORA BOLSONARO! bem grande");
    }
    
}

static void CriarDireitoriosGlobo()
{
    
    var path = Path.Combine(Environment.CurrentDirectory, "globo");
    if(!Directory.Exists(path))
    {
    var dirGlobo = Directory.CreateDirectory(path);
    var dirAmNorte = dirGlobo.CreateSubdirectory("América do Norte");
    var dirAmCentral = dirGlobo.CreateSubdirectory("América Central");
    var dirAmSul = dirGlobo.CreateSubdirectory("América do Sul");

    dirAmNorte.CreateSubdirectory("USA");
    dirAmNorte.CreateSubdirectory("Canadá");
    dirAmNorte.CreateSubdirectory("Mexíco");

    dirAmCentral.CreateSubdirectory("Costa Rica");
    dirAmCentral.CreateSubdirectory("Panamá");

    dirAmSul.CreateSubdirectory("Brasil");
    dirAmSul.CreateSubdirectory("Argentina");
    dirAmSul.CreateSubdirectory("Paraguai");
    }

}




