import logo from './logo.svg';
import axios from 'axios'
import React, { useEffect, useState } from 'react';

function App() {

  const [allAnswers, SetallAnswers] = useState([]);
  const getAllAnswers = async () => {
    await axios.get('http://localhost:5076/api/AssessmentAnswer').then(res => {
      const data = res.data;
      console.log(data);
      SetallAnswers(data);
      return data
    })
  }

  useEffect(() => {
    getAllAnswers();
  }, []);

  // const handleAnswer = (answer) => {
  //   if (answer === "ms") {
  //     answer.forEach(element => {
  //       console.log(element)
  //       return element +1
  //     });
  //   }else{
  //    return answer
  //   }
  // }

  return (
    <div className="App">
      <h1>Hello</h1>
      {allAnswers.map((x) => (

        <card value={x.id} >
          <h3> <p>Question_NUM :{x.assessments_Questions.id}</p></h3>
          <p>Type : {x.assessments_Questions.type}</p>

          <p color='warning'>Question : {x.assessments_Questions.question}</p>

          <p color='green'>Answer : {
            x.answer

          }</p>
        </card>
      ))}
    </div>
  );
}

export default App;
