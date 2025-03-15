import React, { useState } from 'react';

const AnswerChecker = ({ extractedText, answerKey }) => {
  const [score, setScore] = useState(null);

  const parseAnswers = (text) => {
    // פונקציה לפירוק הטקסט לתשובות
    const lines = text.split('\n');
    const answers = lines.map(line => {
      const match = line.match(/(\d+)\.\s*([A-D])/i);
      return match ? { question: parseInt(match[1]), answer: match[2].toUpperCase() } : null;
    }).filter(Boolean);
    return answers;
  };

  const calculateScore = () => {
    const studentAnswers = parseAnswers(extractedText);
    let correctCount = 0;
    studentAnswers.forEach(({ question, answer }) => {
      if (answerKey[question] && answerKey[question] === answer) {
        correctCount++;
      }
    });
    setScore(correctCount);
  };

  return (
    <div>
      <button onClick={calculateScore} disabled={!extractedText}>
        חשב ציון
      </button>
      {score !== null && (
        <p>הציון שלך: {score} מתוך {Object.keys(answerKey).length}</p>
      )}
    </div>
  );
};

export default AnswerChecker;
