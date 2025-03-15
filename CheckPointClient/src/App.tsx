import React, { useState } from 'react';
import OCRComponent from './OCRComponent';
import AnswerChecker from './AnswerChecker';

const App = () => {
  const [extractedText, setExtractedText] = useState('');

  // מפתח תשובות לדוגמה
  const answerKey = {
    1: 'A',
    2: 'C',
    3: 'B',
    4: 'D',
    5: 'A',
    // הוסף את כל התשובות הנכונות כאן
  };

  return (
    <div>
      <Rt/>
      <h1>מערכת בדיקת מבחנים אמריקאיים</h1>
      <OCRComponent onExtractedText={setExtractedText} />
      <AnswerChecker extractedText={extractedText} answerKey={answerKey} />
    </div>
  );
};

export default App;
