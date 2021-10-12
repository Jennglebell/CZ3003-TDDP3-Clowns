using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Networking;
using Newtonsoft.Json;

namespace apiManagers{
    public class DataAcessManager : MonoBehaviour
    {
        public string url_user;
        public string url_qn;
        
        void Start(){
            // By name
            var userId = "7HHcjbfJq1kD8VFMHHDq";
            
            // Code to get user details
            var linktoUserGet = GameObject.FindWithTag("Dao").GetComponent<UserDao>();
            Debug.Log("============Starting Data Access Manager========");
            Debug.Log(linktoUserGet);
            User user = linktoUserGet.getUser(url_user, userId);
            Debug.Log(user.getId());
            
            // Code to create user
            //User user2 = new User("Harry Potter", 400, 5);
            //string result = linktoUserGet.createUser(url_user, user2);
            //Debug.Log(result);

            // Code to delete user
            //userId = "mlDuFwswQXuf6Hyo1JyY";
            //string res = linktoUserGet.deleteUser(url_user, userId);
            //Debug.Log(res);

            // Code to update user
            //User user2 = linktoUserGet.getUser(url_user, "7HHcjbfJq1kD8VFMHHDq");
            //user2.setEloRating(500000);
            //string result = linktoUserGet.updateUser(url_user, user2);
            //Debug.Log(result);

            var linktoQuestionGet = GameObject.FindWithTag("Dao").GetComponent<QuestionDao>();
            // Code to get questions from db
            /*var primaryLevel = 4;
            
            List<QuestionSO> qnList = linktoQuestionGet.getQuestions(url_qn, primaryLevel);
            foreach (var qn in qnList)
            {
                Debug.Log(qn.ToJSON);
            }

            */
        }
    }
}

