import React from 'react';
import Button from '@mui/material/Button';

function CustomButton({ variant = "contained", color = "primary", children, ...otherProps }) {
    return (
        <Button variant={variant} color={color} {...otherProps} sx={{ width: '100%' }}>
            {children}
        </Button>
    );
}

export default CustomButton;
