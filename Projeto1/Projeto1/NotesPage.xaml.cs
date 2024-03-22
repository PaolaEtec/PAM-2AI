namespace Projeto1;

public partial class NotesPage : ContentPage
{
    string content = "";
    string path = Path.Combine(FileSystem.AppDataDirectory, "note.txt");
	public NotesPage()
	{
		InitializeComponent();
	}

    private void SaveButton_Clicked(object sender, EventArgs e)
    {
        content = NoteEditor.Text;
        File.WriteAllText(path, content);
    }

    private void DeleteButton_Clicked(object sender, EventArgs e)
    {

    }
}