var stars = new GithubService().getStars("throwx");

class GithubService
{
    private IEGithubClient _githubClient;
    public int getStars(String repoName )
    {

        return _githubClient.GetRepo(repoName).Stars;
    }
}

public interface IEGithubClient
{
     (String repoName,int Stars) GetRepo(String repoName);
}


class GithubClient:IEGithubClient
{
    public (String repoName, int Stars) GetRepo(String repoName)
    {
        return ( repoName, repoName.Length);
    }
}