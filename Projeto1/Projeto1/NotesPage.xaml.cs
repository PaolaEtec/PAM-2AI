namespace Projeto1;

public partial class NotesPage : ContentPage
{
    string content = "";
    string path = Path.Combine(FileSystem.AppDataDirectory, "note.txt");
	public NotesPage()
	{
		InitializeComponent();
        //verifica se o arquivo existe no caminho dentro do ()
        if (File.Exists(path))
        {
            NoteEditor.Text = File.ReadAllText(path);
        }
	}

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        content = NoteEditor.Text;
        File.WriteAllText(path, content);
        DisplayAlert("Sucesso!", "Arquivo salvo com sucesso", "OK");
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {
        if (File.Exists(path))
        {
            //deleta o arquivo no caminho entre ()
            File.Delete(path);
            NoteEditor.Text = "";
            DisplayAlert("Sucesso!", "Arquivo deletado com sucesso", "OK");
        }
    }
}