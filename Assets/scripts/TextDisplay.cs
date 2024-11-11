using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{
    public string[] texts;      // �e�L�X�g�z��
    int textNumber;             // ���ݕ\�����̃e�L�X�g�ԍ�
    string displayText;         // �\�������e�L�X�g
    int textCharNumber;         // ���ݕ\�����̕����ԍ�
    int displayTextSpeed;       // ������\������X�s�[�h����p
    bool click;                 // �N���b�N���ꂽ���̃t���O
    bool textStop;              // �e�L�X�g�\�����I��������ǂ����̃t���O
    bool isRestarting;          // ���X�^�[�g�����ǂ������Ǘ�
    [SerializeField] GameObject panel;

    void Start()
    {
        StartTextDisplay(); // ���������Ƀe�L�X�g�\�����X�^�[�g
    }

    void Update()
    {
        if (!textStop)
        {
            displayTextSpeed++;

            // 5�t���[�����Ƃ�1�������\������
            if (displayTextSpeed % 5 == 0)
            {
                // ���X�^�[�g���łȂ���΁A�ʏ�̃A�j���[�V���������𑱂���
                if (textCharNumber < texts[textNumber].Length)
                {
                    displayText += texts[textNumber][textCharNumber];
                    textCharNumber++;
                }
                else
                {
                    // ���̃Z���t������ꍇ
                    if (textNumber < texts.Length - 1)
                    {
                        if (click)
                        {
                            displayText = "";  // ���̃Z���t�ɐ؂�ւ�
                            textCharNumber = 0;
                            textNumber++;
                        }
                    }
                    else
                    {
                        // �Ō�̃Z���t���I�������e�L�X�g���~�߂�
                        if (click)
                        {
                            textStop = true;
                            panel.SetActive(false);
                        }
                    }
                }

                // �\�����̃e�L�X�g����ʂɕ\��
                this.GetComponent<Text>().text = displayText;
                click = false; // �N���b�N�t���O�����Z�b�g
            }

            // �}�E�X�N���b�N�����o������t���O�𗧂Ă�
            if (Input.GetMouseButton(0))
            {
                click = true;
            }
        }
    }

    // �e�L�X�g�\�����ŏ������蒼�����\�b�h
    public void RestartTextDisplay()
    {
        Debug.Log("TextDisplay restarting from the beginning.");
        // �\�����̃e�L�X�g�Ɛ���ϐ������Z�b�g
        textNumber = 0; // �e�L�X�g�ԍ����ŏ��ɖ߂�
        textCharNumber = 0; // �����ԍ����ŏ��ɖ߂�
        displayText = "";   // �\������������Z�b�g
        displayTextSpeed = 0; // �X�s�[�h�̃J�E���g�����Z�b�g
        textStop = false;   // �e�L�X�g�\�����ēx�J�n
        isRestarting = false; // ���X�^�[�g���̃t���O�����Z�b�g
        this.GetComponent<Text>().text = displayText; // �e�L�X�gUI�����Z�b�g
        panel.SetActive(true); // �p�l�����ĕ\��
    }

    // �e�L�X�g�\�����ŏ��ɊJ�n���郁�\�b�h
    public void StartTextDisplay()
    {
        textNumber = 0;
        displayText = "";
        textCharNumber = 0;
        displayTextSpeed = 0;
        click = false;
        textStop = false;
        isRestarting = false; // ���������ɂ̓��X�^�[�g���ł͂Ȃ�
        this.GetComponent<Text>().text = displayText; // �e�L�X�g��������
        panel.SetActive(true); // �p�l�����ĕ\��
    }
}



