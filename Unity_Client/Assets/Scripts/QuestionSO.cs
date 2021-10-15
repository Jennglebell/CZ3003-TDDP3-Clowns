using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
    [TextArea(2,6)]
    [SerializeField] string question;
    [SerializeField] string[] answers = new string[4];
    [SerializeField] int correctAnswerIndex;
    [TextArea(2,6)]
    [SerializeField] string hint = "Enter your hint here";

    /*public QuestionSO(string question, string[] answers, int correctanswer)
    {
        this.question = question;
        this.answers = answers;
        this.correctAnswerIndex = correctanswer;
    }*/

    public string GetQuestion()
    {
        return question;
    }

    public string GetAnswer(int index)
    {
        return answers[index];
    }

    public string GetHint()
    {
        return hint;
    }

    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }

    public string ToJSON(){
        return JsonUtility.ToJson(this);
    }
}

/*public class UserQuestions
{
    List<QuestionSO> userQuestions;

    public List<QuestionSO> getQuestions()
    {
        return userQuestions;
    }
}*/
