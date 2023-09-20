import React from 'react';
import TextField from '@mui/material/TextField';

const TextBox = (props) => {
    return (
        <TextField {...props} variant="outlined" sx={{ width: '400px' }} />
    );
};

export default TextBox;
