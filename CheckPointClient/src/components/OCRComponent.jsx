import React, { useState } from 'react';
import { createWorker } from 'tesseract.js';

const OCRComponent = ({ onExtractedText }) => {
  const [image, setImage] = useState(null);
  const [loading, setLoading] = useState(false);

  const worker = createWorker({
    logger: m => console.log(m), // למעקב אחר התקדמות
  });

  const handleChange = (e) => {
    setImage(URL.createObjectURL(e.target.files[0]));
  };

  const handleClick = async () => {
    setLoading(true);
    await worker.load();
    await worker.loadLanguage('eng'); // ניתן להחליף בשפה הרצויה
    await worker.initialize('eng');
    const { data: { text } } = await worker.recognize(image);
    onExtractedText(text);
    setLoading(false);
  };

  return (
    <div>
      <input type="file" onChange={handleChange} />
      <button onClick={handleClick} disabled={!image || loading}>
        {loading ? 'מנתח...' : 'העלה ובצע OCR'}
      </button>
    </div>
  );
};

export default OCRComponent;
