import React from 'react';
import TextField from '@mui/material/TextField';

const TextBox = (props) => {
    return (
        <TextField
            {...props}
            variant="outlined"
            fullWidth
            size="small"
        />
    );
};

export default TextBox;
