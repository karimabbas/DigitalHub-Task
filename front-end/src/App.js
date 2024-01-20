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

  const handleAnswer = (type, answer) => {

    if (type === "match" || type === "fill") {
      var x = JSON.parse(answer)

     return x.map((y) => " Question : " + y.question + " ===> Answer " + y.answer );

      // return x
    }
    return answer
    // console.log(answer)
  }

  return (
    <div className="App">
      <h1>Hello</h1>
      {allAnswers.map((x) => (

        <card value={x.id} >
          <h3> <p>Question_NUM :{x.assessments_Questions.id}</p></h3>
          <p>Type : {x.assessments_Questions.type}</p>

          <p color='warning'>Question : {x.assessments_Questions.question}</p>

          <p color='green'>Answer : {
            handleAnswer(x.assessments_Questions.type, x.answer)

          }</p>
        </card>
      ))}
    </div>
  );
}

export default App;
